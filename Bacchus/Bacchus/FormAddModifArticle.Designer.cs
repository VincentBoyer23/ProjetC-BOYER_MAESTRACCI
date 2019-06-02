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
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRefArticle = new System.Windows.Forms.Label();
            this.textBoxRefArticle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxRefArticle);
            this.panel1.Controls.Add(this.labelRefArticle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 311);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxPrixHT
            // 
            this.textBoxPrixHT.Location = new System.Drawing.Point(454, 179);
            this.textBoxPrixHT.Name = "textBoxPrixHT";
            this.textBoxPrixHT.Size = new System.Drawing.Size(81, 22);
            this.textBoxPrixHT.TabIndex = 9;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(454, 238);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(81, 22);
            this.textBoxQuantite.TabIndex = 8;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(360, 239);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(70, 17);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantité :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(317, 186);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(113, 17);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Prix unitaire HT :";
            // 
            // comboBoxSousFamille
            // 
            this.comboBoxSousFamille.FormattingEnabled = true;
            this.comboBoxSousFamille.Location = new System.Drawing.Point(154, 239);
            this.comboBoxSousFamille.Name = "comboBoxSousFamille";
            this.comboBoxSousFamille.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSousFamille.TabIndex = 5;
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(154, 179);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMarque.TabIndex = 4;
            // 
            // labelSousFamille
            // 
            this.labelSousFamille.AutoSize = true;
            this.labelSousFamille.Location = new System.Drawing.Point(3, 239);
            this.labelSousFamille.Name = "labelSousFamille";
            this.labelSousFamille.Size = new System.Drawing.Size(92, 17);
            this.labelSousFamille.TabIndex = 3;
            this.labelSousFamille.Text = "SousFamille :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(3, 186);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(64, 17);
            this.labelMarque.TabIndex = 2;
            this.labelMarque.Text = "Marque :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 44);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(87, 17);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description :";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(6, 64);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(606, 96);
            this.richTextBoxDesc.TabIndex = 0;
            this.richTextBoxDesc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "€";
            // 
            // labelRefArticle
            // 
            this.labelRefArticle.AutoSize = true;
            this.labelRefArticle.Location = new System.Drawing.Point(8, 12);
            this.labelRefArticle.Name = "labelRefArticle";
            this.labelRefArticle.Size = new System.Drawing.Size(82, 17);
            this.labelRefArticle.TabIndex = 12;
            this.labelRefArticle.Text = "Reference :";
            // 
            // textBoxRefArticle
            // 
            this.textBoxRefArticle.Location = new System.Drawing.Point(96, 7);
            this.textBoxRefArticle.Name = "textBoxRefArticle";
            this.textBoxRefArticle.Size = new System.Drawing.Size(108, 22);
            this.textBoxRefArticle.TabIndex = 13;
            // 
            // FormAddModifArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 335);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRefArticle;
        private System.Windows.Forms.Label labelRefArticle;
    }
}