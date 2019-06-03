namespace Bacchus
{

    /// <summary>
    /// Fenêtre export vers fichier CSV.
    /// </summary>
    partial class FormExportCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportCSV));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenFileForm = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxFileName);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpenFileForm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(512, 90);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(4, 4);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(412, 22);
            this.textBoxFileName.TabIndex = 3;
            // 
            // buttonOpenFileForm
            // 
            this.buttonOpenFileForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpenFileForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFileForm.Image")));
            this.buttonOpenFileForm.Location = new System.Drawing.Point(424, 4);
            this.buttonOpenFileForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenFileForm.Name = "buttonOpenFileForm";
            this.buttonOpenFileForm.Size = new System.Drawing.Size(80, 74);
            this.buttonOpenFileForm.TabIndex = 2;
            this.buttonOpenFileForm.UseVisualStyleBackColor = true;
            this.buttonOpenFileForm.Click += new System.EventHandler(this.buttonOpenFileForm_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxLog);
            this.groupBox.Controls.Add(this.flowLayoutPanel2);
            this.groupBox.Controls.Add(this.progressBarExport);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 134);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(512, 188);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Exportation";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxLog.Location = new System.Drawing.Point(4, 19);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(228, 137);
            this.textBoxLog.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonExport);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(241, 19);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 137);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonExport
            // 
            this.buttonExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExport.Location = new System.Drawing.Point(0, 4);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(263, 133);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // progressBarExport
            // 
            this.progressBarExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarExport.Location = new System.Drawing.Point(4, 156);
            this.progressBarExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(504, 28);
            this.progressBarExport.Step = 1;
            this.progressBarExport.TabIndex = 0;
            // 
            // FormExportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExportCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export CSV";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonOpenFileForm;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ProgressBar progressBarExport;
    }
}