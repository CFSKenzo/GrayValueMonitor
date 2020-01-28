namespace GrayValueMonitor
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_MonitorPath = new System.Windows.Forms.TextBox();
            this.Button_StartMonitor = new System.Windows.Forms.Button();
            this.FDDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.FDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Button_StopMonitor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.FDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitor Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_MonitorPath
            // 
            this.TextBox_MonitorPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_MonitorPath.Location = new System.Drawing.Point(606, 3);
            this.TextBox_MonitorPath.Name = "TextBox_MonitorPath";
            this.TextBox_MonitorPath.Size = new System.Drawing.Size(598, 26);
            this.TextBox_MonitorPath.TabIndex = 1;
            // 
            // Button_StartMonitor
            // 
            this.Button_StartMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_StartMonitor.Location = new System.Drawing.Point(3, 3);
            this.Button_StartMonitor.Name = "Button_StartMonitor";
            this.Button_StartMonitor.Size = new System.Drawing.Size(597, 68);
            this.Button_StartMonitor.TabIndex = 2;
            this.Button_StartMonitor.Text = "Start Monitor";
            this.Button_StartMonitor.UseVisualStyleBackColor = true;
            this.Button_StartMonitor.Click += new System.EventHandler(this.Button_StartMonitor_Click);
            // 
            // FDDataGridView
            // 
            this.FDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FDDataGridView.Location = new System.Drawing.Point(3, 163);
            this.FDDataGridView.Name = "FDDataGridView";
            this.FDDataGridView.RowHeadersWidth = 62;
            this.FDDataGridView.RowTemplate.Height = 28;
            this.FDDataGridView.Size = new System.Drawing.Size(1207, 475);
            this.FDDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimal Image number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDNumericUpDown
            // 
            this.FDNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FDNumericUpDown.Location = new System.Drawing.Point(606, 3);
            this.FDNumericUpDown.Name = "FDNumericUpDown";
            this.FDNumericUpDown.Size = new System.Drawing.Size(598, 26);
            this.FDNumericUpDown.TabIndex = 4;
            this.FDNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FDNumericUpDown.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // Button_StopMonitor
            // 
            this.Button_StopMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_StopMonitor.Location = new System.Drawing.Point(606, 3);
            this.Button_StopMonitor.Name = "Button_StopMonitor";
            this.Button_StopMonitor.Size = new System.Drawing.Size(598, 68);
            this.Button_StopMonitor.TabIndex = 2;
            this.Button_StopMonitor.Text = "Stop Monitor";
            this.Button_StopMonitor.UseVisualStyleBackColor = true;
            this.Button_StopMonitor.Click += new System.EventHandler(this.Button_StopMonitor_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FDDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 641);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_MonitorPath, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1207, 34);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Button_StartMonitor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Button_StopMonitor, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1207, 74);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.FDNumericUpDown, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1207, 34);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Gray Value Monitor";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.FDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_MonitorPath;
        private System.Windows.Forms.Button Button_StartMonitor;
        private System.Windows.Forms.DataGridView FDDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FDNumericUpDown;
        private System.Windows.Forms.Button Button_StopMonitor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

