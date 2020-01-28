namespace GrayValueMonitor
{
    partial class FDPictureBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FDTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.SubPictureBox = new System.Windows.Forms.PictureBox();
            this.Label_Data = new System.Windows.Forms.Label();
            this.FDTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FDTableLayoutPanel
            // 
            this.FDTableLayoutPanel.ColumnCount = 1;
            this.FDTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FDTableLayoutPanel.Controls.Add(this.Label_Title, 0, 0);
            this.FDTableLayoutPanel.Controls.Add(this.SubPictureBox, 0, 1);
            this.FDTableLayoutPanel.Controls.Add(this.Label_Data, 0, 2);
            this.FDTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FDTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FDTableLayoutPanel.Name = "FDTableLayoutPanel";
            this.FDTableLayoutPanel.RowCount = 3;
            this.FDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.45387F));
            this.FDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.54613F));
            this.FDTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.FDTableLayoutPanel.Size = new System.Drawing.Size(636, 463);
            this.FDTableLayoutPanel.TabIndex = 1;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Label_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Title.Location = new System.Drawing.Point(3, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(630, 74);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Label_Title";
            this.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubPictureBox
            // 
            this.SubPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubPictureBox.Location = new System.Drawing.Point(3, 77);
            this.SubPictureBox.Name = "SubPictureBox";
            this.SubPictureBox.Size = new System.Drawing.Size(630, 321);
            this.SubPictureBox.TabIndex = 1;
            this.SubPictureBox.TabStop = false;
            this.SubPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SubPictureBox_Paint);
            this.SubPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SubPictureBox_MouseDown);
            this.SubPictureBox.MouseHover += new System.EventHandler(this.SubPictureBox_MouseHover);
            this.SubPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SubPictureBox_MouseMove);
            this.SubPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubPictureBox_MouseUp);
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Data.Location = new System.Drawing.Point(3, 401);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(630, 62);
            this.Label_Data.TabIndex = 2;
            this.Label_Data.Text = "Label Data";
            this.Label_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FDPictureBox
            // 
            this.Controls.Add(this.FDTableLayoutPanel);
            this.Name = "FDPictureBox";
            this.Size = new System.Drawing.Size(636, 463);
            this.FDTableLayoutPanel.ResumeLayout(false);
            this.FDTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel FDTableLayoutPanel;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.PictureBox SubPictureBox;
        private System.Windows.Forms.Label Label_Data;
    }
}
