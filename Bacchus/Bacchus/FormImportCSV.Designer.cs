namespace Bacchus
{
    partial class FormImportCSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportCSV));
            this.progressBarImport = new System.Windows.Forms.ProgressBar();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddDB = new System.Windows.Forms.Button();
            this.buttonWipeAddDB = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonOpenFileForm = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarImport
            // 
            this.progressBarImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarImport.Location = new System.Drawing.Point(3, 127);
            this.progressBarImport.Name = "progressBarImport";
            this.progressBarImport.Size = new System.Drawing.Size(378, 23);
            this.progressBarImport.Step = 1;
            this.progressBarImport.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxLog);
            this.groupBox.Controls.Add(this.flowLayoutPanel2);
            this.groupBox.Controls.Add(this.progressBarImport);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 109);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(384, 153);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Importation";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxLog.Location = new System.Drawing.Point(3, 16);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(172, 111);
            this.textBoxLog.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonAddDB);
            this.flowLayoutPanel2.Controls.Add(this.buttonWipeAddDB);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(181, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 111);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonAddDB
            // 
            this.buttonAddDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddDB.Location = new System.Drawing.Point(122, 3);
            this.buttonAddDB.Name = "buttonAddDB";
            this.buttonAddDB.Size = new System.Drawing.Size(75, 58);
            this.buttonAddDB.TabIndex = 1;
            this.buttonAddDB.Text = "Ajout BDD";
            this.buttonAddDB.UseVisualStyleBackColor = true;
            this.buttonAddDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWipeAddDB
            // 
            this.buttonWipeAddDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWipeAddDB.Location = new System.Drawing.Point(41, 3);
            this.buttonWipeAddDB.Name = "buttonWipeAddDB";
            this.buttonWipeAddDB.Size = new System.Drawing.Size(75, 58);
            this.buttonWipeAddDB.TabIndex = 2;
            this.buttonWipeAddDB.Text = "Ecrasement + Ajout";
            this.buttonWipeAddDB.UseVisualStyleBackColor = true;
            this.buttonWipeAddDB.Click += new System.EventHandler(this.buttonWipeAddDB_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonOpenFileForm
            // 
            this.buttonOpenFileForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpenFileForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFileForm.Image")));
            this.buttonOpenFileForm.Location = new System.Drawing.Point(319, 3);
            this.buttonOpenFileForm.Name = "buttonOpenFileForm";
            this.buttonOpenFileForm.Size = new System.Drawing.Size(60, 60);
            this.buttonOpenFileForm.TabIndex = 2;
            this.buttonOpenFileForm.UseVisualStyleBackColor = true;
            this.buttonOpenFileForm.Click += new System.EventHandler(this.buttonOpenFileForm_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(3, 3);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(310, 20);
            this.textBoxFileName.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxFileName);
            this.flowLayoutPanel1.Controls.Add(this.buttonOpenFileForm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 73);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FormImportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormImportCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import CSV";
            this.Load += new System.EventHandler(this.FormImportCSV_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarImport;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonWipeAddDB;
        private System.Windows.Forms.Button buttonAddDB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button buttonOpenFileForm;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}