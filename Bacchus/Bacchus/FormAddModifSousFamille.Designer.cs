namespace formforproject
{
    partial class FormAddModifSousFamille
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
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFamille = new System.Windows.Forms.ComboBox();
            this.labelFamille = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Location = new System.Drawing.Point(206, 63);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(101, 37);
            this.Confirmbutton.TabIndex = 0;
            this.Confirmbutton.Text = "Confirmer";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFamille);
            this.panel1.Controls.Add(this.Confirmbutton);
            this.panel1.Controls.Add(this.labelFamille);
            this.panel1.Controls.Add(this.Namelabel);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 103);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxFamille
            // 
            this.comboBoxFamille.FormattingEnabled = true;
            this.comboBoxFamille.Location = new System.Drawing.Point(144, 33);
            this.comboBoxFamille.Name = "comboBoxFamille";
            this.comboBoxFamille.Size = new System.Drawing.Size(163, 24);
            this.comboBoxFamille.TabIndex = 4;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Location = new System.Drawing.Point(3, 36);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(60, 17);
            this.labelFamille.TabIndex = 3;
            this.labelFamille.Text = "Famille :";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(3, 3);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(125, 17);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Nom SousFamille :";
            // 
            // FormAddModifSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 130);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddModifSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creation SousFamille";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.ComboBox comboBoxFamille;
        private System.Windows.Forms.Label labelFamille;
    }
}