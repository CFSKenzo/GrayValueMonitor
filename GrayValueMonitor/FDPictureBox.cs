using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GrayValueMonitor
{
    public partial class FDPictureBox : UserControl
    {
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int nxDest, int nyDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        public FDPictureBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private Bitmap m_Bitmap = null;
        private List<Rectangle> m_ROIList = new List<Rectangle>();
        private double m_Scale = 0.0;
        private double m_ShiftX = 0.0;
        private double m_ShiftY = 0.0;
        public void LoadImage(Bitmap f_Bitmap)
        {
            m_Bitmap = f_Bitmap;
            m_ROIList.Add(new Rectangle(1, 1, 20, 20));
            Refresh();
        }
        public void LoadROI(Point f_FirstPoint, Point f_LastPoint)
        {
            m_ROIList.Add(new Rectangle(f_FirstPoint.X, f_FirstPoint.Y, f_LastPoint.X - f_FirstPoint.X, f_LastPoint.Y - f_FirstPoint.Y));
        }

        private void SubPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Invalidate(true);
            if (m_Bitmap != null)
            {
                Bitmap t_BitmapBuffer = new Bitmap(m_Bitmap);
                Graphics t_BufferGraphic = Graphics.FromImage(t_BitmapBuffer);
                t_BufferGraphic.DrawImage(m_Bitmap, 0, 0);

                //Graphics t_BitmapGraphic = Graphics.FromImage(m_Bitmap);
                //t_BufferGraphic.DrawImage(m_Bitmap, 0,0);
                foreach (Rectangle t_ROI in m_ROIList)
                {
                    t_BufferGraphic.DrawRectangle(new Pen(Color.Red, 500), new Rectangle(0, 0, 1000, 1000));
                }

                Graphics t_Graphic = e.Graphics;

                t_Graphic.DrawImage(t_BitmapBuffer, 0, 0, ((PictureBox)sender).Width, ((PictureBox)sender).Height);

                t_BitmapBuffer.Dispose();
                t_BitmapBuffer = null;
            }
            Invalidate(false);

        }

        private void SubPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void SubPictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void SubPictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void SubPictureBox_MouseHover(object sender, EventArgs e)
        {

        }

    }
}
