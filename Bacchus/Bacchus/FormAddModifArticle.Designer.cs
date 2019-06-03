namespace formforproject
{
    partial class FormAddModifArticle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRefArticle = new System.Windows.Forms.TextBox();
            this.labelRefArticle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.textBoxPrixHT = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxSousFamille = new System.Windows.Forms.ComboBox();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.labelSousFamille = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxRefArticle);
            this.panel1.Controls.Add(this.labelRefArticle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonConfirm);
            this.panel1.Controls.Add(this.textBoxPrixHT);
            this.panel1.Controls.Add(this.textBoxQuantite);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.comboBoxSousFamille);
            this.panel1.Controls.Add(this.comboBoxMarque);
            this.panel1.Controls.Add(this.labelSousFamille);
            this.panel1.Controls.Add(this.labelMarque);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.richTextBoxDesc);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 389);
            this.panel1.TabIndex = 0;
            // 
            // textBoxRefArticle
            // 
            this.textBoxRefArticle.Location = new System.Drawing.Point(108, 9);
            this.textBoxRefArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRefArticle.Name = "textBoxRefArticle";
            this.textBoxRefArticle.Size = new System.Drawing.Size(121, 26);
            this.textBoxRefArticle.TabIndex = 13;
            // 
            // labelRefArticle
            // 
            this.labelRefArticle.AutoSize = true;
            this.labelRefArticle.Location = new System.Drawing.Point(9, 15);
            this.labelRefArticle.Name = "labelRefArticle";
            this.labelRefArticle.Size = new System.Drawing.Size(92, 20);
            this.labelRefArticle.TabIndex = 12;
            this.labelRefArticle.Text = "Reference :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "€";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(587, 332);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(101, 52);
            this.ButtonConfirm.TabIndex = 10;
            this.ButtonConfirm.Text = "Confirmer";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // textBoxPrixHT
            // 
            this.textBoxPrixHT.Location = new System.Drawing.Point(511, 224);
            this.textBoxPrixHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrixHT.Name = "textBoxPrixHT";
            this.textBoxPrixHT.Size = new System.Drawing.Size(91, 26);
            this.textBoxPrixHT.TabIndex = 9;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(511, 298);
            this.textBoxQuantite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(91, 26);
            this.textBoxQuantite.TabIndex = 8;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(405, 299);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(78, 20);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantité :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(357, 232);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(123, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Prix unitaire HT :";
            // 
            // comboBoxSousFamille
            // 
            this.comboBoxSousFamille.FormattingEnabled = true;
            this.comboBoxSousFamille.Location = new System.Drawing.Point(173, 299);
            this.comboBoxSousFamille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSousFamille.Name = "comboBoxSousFamille";
            this.comboBoxSousFamille.Size = new System.Drawing.Size(136, 28);
            this.comboBoxSousFamille.TabIndex = 5;
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(173, 224);
            this.comboBoxMarque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(136, 28);
            this.comboBoxMarque.TabIndex = 4;
            // 
            // labelSousFamille
            // 
            this.labelSousFamille.AutoSize = true;
            this.labelSousFamille.Location = new System.Drawing.Point(3, 299);
            this.labelSousFamille.Name = "labelSousFamille";
            this.labelSousFamille.Size = new System.Drawing.Size(104, 20);
            this.labelSousFamille.TabIndex = 3;
            this.labelSousFamille.Text = "SousFamille :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(3, 232);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(71, 20);
            this.labelMarque.TabIndex = 2;
            this.labelMarque.Text = "Marque :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(97, 20);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description :";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(7, 80);
            this.richTextBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(681, 119);
            this.richTextBoxDesc.TabIndex = 0;
            this.richTextBoxDesc.Text = "";
            // 
            // FormAddModifArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddModifArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creation Article";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSousFamille;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.Label labelSousFamille;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.TextBox textBoxPrixHT;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRefArticle;
        private System.Windows.Forms.Label labelRefArticle;
    }
}