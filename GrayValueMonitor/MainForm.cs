using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayValueMonitor
{
    
    public partial class MainForm : Form
    {
        
        FolderMonitor m_FolderMonitor = FolderMonitor.GetFolderMonitor();
        static System.Threading.Mutex m_Mutex = new System.Threading.Mutex();
        static List<DataGridViewRow> m_CheckList = new List<DataGridViewRow>();
        Task m_GrayValueTask = new Task(new Action(GrayValueTask));
        #region ImageNameMapping("0": "CG1 , "15_1": "R1")
        static Dictionary<string, string> m_ImageNameMappings = new Dictionary<string, string>();
        private void LoadImageNameMappings()
        {
            string t_ImageNameMappingsContents = System.IO.File.ReadAllText("ImageNameMapping.json");
            m_ImageNameMappings = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(t_ImageNameMappingsContents);
        }
        #endregion
        #region FixROILocations("1": [0,1],[2,3], "15_1":[4,7],[9,10])

        static Dictionary<string, Point[]> m_FixROILocations = new Dictionary<string, Point[]>();

        private void LoadFixROILocations()
        {
            string t_FixROILocationsContents = System.IO.File.ReadAllText("FixedROILocations.json");
            Dictionary<string, object> t_FixROILocationsJson = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(t_FixROILocationsContents);
            foreach(KeyValuePair<string, object> t_FixROILocationJson in t_FixROILocationsJson)
            {
                Newtonsoft.Json.Linq.JArray t_JArrays = t_FixROILocationJson.Value as Newtonsoft.Json.Linq.JArray;
                Point t_FirstPoint = new Point(-1,-1);
                Point t_LastPoint = new Point(-1, -1);
                foreach (Newtonsoft.Json.Linq.JArray t_JArray in t_JArrays)
                {
                    if(t_FirstPoint.X == -1 && t_FirstPoint.Y == -1)
                    {
                        t_FirstPoint = new Point(int.Parse(t_JArray[0].ToString()), int.Parse(t_JArray[1].ToString()));
                    }
                    else
                    {
                        t_LastPoint = new Point(int.Parse(t_JArray[0].ToString()), int.Parse(t_JArray[1].ToString()));
                    }
                }
                m_FixROILocations.Add(t_FixROILocationJson.Key, new Point[2]{ t_FirstPoint, t_LastPoint});
                
            }
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
            LoadImageNameMappings();
            LoadFixROILocations();
            m_CheckList.Clear();
            m_FolderMonitor.Event_DetectCreateFolder += M_FolderMonitor_Event_DetectCreateFolder;
            FDDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FDDataGridView.MultiSelect = false;
            DataGridViewColumn s = new DataGridViewColumn();
            DataGridViewColumn t_DataGridViewColumn = new DataGridViewColumn();
            FDDataGridView.Columns.Add("DateTime", "Date Time");
            FDDataGridView.Columns.Add("FolderPath", "Folder Path");
            FDDataGridView.Columns.Add("ImageNumber", "Image Number");
            foreach(KeyValuePair<string, string> t_ImageNameMapping in m_ImageNameMappings)
            {
                FDDataGridView.Columns.Add(t_ImageNameMapping.Value, t_ImageNameMapping.Value);
                FDDataGridView.Columns[t_ImageNameMapping.Value].Width = 50;
            }
            FDDataGridView.AllowUserToAddRows = false;

            if(System.IO.File.Exists("Results.csv") == false)
            {
                string t_ResultsTitle = string.Empty;
                foreach (DataGridViewColumn t_FDDataGridViewHeader in FDDataGridView.Columns)
                {
                    t_ResultsTitle += t_FDDataGridViewHeader.HeaderText + ",";
                }
                t_ResultsTitle = t_ResultsTitle.Remove(t_ResultsTitle.Length - 1, 1);
                System.IO.File.AppendAllText("Results.csv", t_ResultsTitle);
                System.IO.File.AppendAllText("Results.csv", System.Environment.NewLine);
            }
            FDDataGridView.RowsAdded -= FDDataGridView_RowsAdded;
            m_GrayValueTask.Start();

            //fdPictureBox1.LoadImage(new Bitmap(@"C:\Users\FDLaptop-Kenzo\Desktop\Test\1234\45_45_13_0_134723179.bmp"));
        }
        private static void GrayValueTask()
        {
            while (true)
            {
                while (m_CheckList.Count > 0)
                {
                    DataGridViewRow t_Checks = m_CheckList[0];
                    lock (m_Mutex)
                    {
                        string t_FolderPath = t_Checks.Cells["FolderPath"].Value.ToString();
                        string[] t_ImageFiles = System.IO.Directory.GetFiles(t_FolderPath);
                        foreach (string t_ImageFile in t_ImageFiles)
                        {
                            string[] t_ImageFileSplit = System.IO.Path.GetFileNameWithoutExtension(t_ImageFile).Split('_');
                            string t_StationNumber = t_ImageFileSplit[2];
                            if (t_ImageFileSplit[2].CompareTo("15") == 0)
                            {
                                t_StationNumber = t_ImageFileSplit[2] + "_" + t_ImageFileSplit[3];
                            }
                            string t_StationName = m_ImageNameMappings[t_StationNumber];
                            Point[] t_ROI = m_FixROILocations[t_StationName];

                            System.Drawing.Bitmap t_Bitmap = new Bitmap(t_ImageFile);

                            Emgu.CV.Mat t_Mat = Emgu.CV.CvInvoke.Imread(t_ImageFile, Emgu.CV.CvEnum.ImreadModes.AnyColor);
                            //Emgu.CV.CvInvoke.NamedWindow("A", Emgu.CV.CvEnum.NamedWindowType.FreeRatio);
                            double t_Average = 0.0;
                            if (t_Bitmap.PixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
                            {
                                Emgu.CV.Image<Emgu.CV.Structure.Gray, byte> t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Gray, byte>(t_Mat.Bitmap);
                                t_Image.ROI = new Rectangle(t_ROI[0].X, t_ROI[0].Y, t_ROI[1].X - t_ROI[0].X, t_ROI[1].Y - t_ROI[0].Y);
                                Emgu.CV.Structure.Gray t_AverageBGR = t_Image.GetAverage();
                                t_Average = t_AverageBGR.MCvScalar.V0;
                                t_Image.Dispose();
                                t_Image = null;
                            }
                            else
                            {
                                Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(t_Mat.Bitmap);
                                t_Image.ROI = new Rectangle(t_ROI[0].X, t_ROI[0].Y, t_ROI[1].X - t_ROI[0].X, t_ROI[1].Y - t_ROI[0].Y);
                                Emgu.CV.Structure.Bgr t_AverageBGR = t_Image.GetAverage();
                                t_Average = t_AverageBGR.MCvScalar.V2;
                                t_Image.Dispose();
                                t_Image = null;
                            }
                            t_Checks.Cells[t_StationName].Value = t_Average;
                            t_Mat.Dispose();
                            t_Mat = null;
                            t_Bitmap.Dispose();
                            t_Bitmap = null;
                            GC.Collect();
                        }
                    }
                    string t_ResultsString = string.Empty;
                    foreach (DataGridViewCell t_Check in t_Checks.Cells)
                    {

                        t_ResultsString += t_Check.Value + ",";
                    }
                    t_ResultsString= t_ResultsString.Remove(t_ResultsString.Length - 1, 1);
                    System.IO.File.AppendAllText("Results.csv", t_ResultsString);
                    System.IO.File.AppendAllText("Results.csv", System.Environment.NewLine);

                    m_CheckList.RemoveAt(0);
                }

            }

        }

        private void M_FolderMonitor_Event_DetectCreateFolder(string f_DateTime, string f_FolderPath)
        {
            this.Invoke((MethodInvoker)delegate
           {
               int t_RowIndex = FDDataGridView.Rows.Add(new string[] { f_DateTime, f_FolderPath, "-1" });
           });
        }

        private void Button_StartMonitor_Click(object sender, EventArgs e)
        {
            if(System.IO.Directory.Exists(TextBox_MonitorPath.Text) == true)
            {
                m_FolderMonitor.StartMonitor(TextBox_MonitorPath.Text);
            }
            Button_StartMonitor.Enabled = false;
            Button_StopMonitor.Enabled = true;
        }
        private void FDDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
                Task.Factory.StartNew(new Action(() =>
                {
                    while (true)
                    {
                        System.Threading.Thread.Sleep(5000);
                        int t_ImageNumber = System.IO.Directory.GetFiles(FDDataGridView.Rows[e.RowIndex].Cells["FolderPath"].Value.ToString()).Length;
                        FDDataGridView.Rows[e.RowIndex].Cells["ImageNumber"].Value = t_ImageNumber;
                        if (t_ImageNumber >= FDNumericUpDown.Value)
                        {
                            string[] t_Images = System.IO.Directory.GetFiles(FDDataGridView.Rows[e.RowIndex].Cells["FolderPath"].Value.ToString());
                            bool t_AreImagesDone = false;
                            while (t_AreImagesDone == false)
                            {
                                foreach (string t_Image in t_Images)
                                {
                                    try
                                    {
                                        System.IO.FileStream t_FileStream = System.IO.File.Open(t_Image, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
                                        t_AreImagesDone = true;
                                        t_FileStream.Close();
                                    }
                                    catch (Exception Ex)
                                    {
                                        t_AreImagesDone = false;
                                    }
                                    if(t_AreImagesDone == false)
                                    {
                                        System.Threading.Thread.Sleep(5000);
                                        break;
                                    }
                                }
                            }
                            lock (m_Mutex)
                            {
                                m_CheckList.Add(FDDataGridView.Rows[e.RowIndex]);
                            }
                            break;
                        }
                    }
                }));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FDDataGridView.RowsAdded += FDDataGridView_RowsAdded;
        }

        private void Button_StopMonitor_Click(object sender, EventArgs e)
        {
            m_FolderMonitor.StopMonitor();
            Button_StartMonitor.Enabled = false;
            Button_StopMonitor.Enabled = true;
        }

        private void Button_AddOnePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog t_FolderBrowserFialog = new FolderBrowserDialog();
            if(t_FolderBrowserFialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            int t_RowIndex = FDDataGridView.Rows.Add(new string[] { DateTime.Now.ToString("yyyyMMdd-HHmmss-fff"), t_FolderBrowserFialog.SelectedPath, "-1", "No" });

        }
    }
}