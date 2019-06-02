using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formforproject
{
    
    public partial class FormAddModifArticle : Form
    {
        private String RefArticle;
        public FormAddModifArticle(String RefArticle)
        {
            InitializeComponent();
            this.RefArticle = RefArticle;
            this.comboBoxSousFamille.DataSource = MeinController.GetAllSousFamilles();
            this.comboBoxSousFamille.DisplayMember = "nom";
            this.comboBoxSousFamille.ValueMember = "nom";
            this.comboBoxSousFamille.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMarque.DataSource = MeinController.GetAllMarques();
            this.comboBoxMarque.DisplayMember = "nom";
            this.comboBoxMarque.ValueMember = "nom";
            this.comboBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList;
            if (RefArticle!=null)
            {
                Article article = MeinController.GetArticleByRef(RefArticle);
                this.Text = "Modification SousFamille";
                this.textBoxRefArticle.Text = RefArticle;
                this.textBoxRefArticle.Enabled = false;
                this.richTextBoxDesc.Text = article.Description;
                this.comboBoxMarque.SelectedValue = article.Marque.Nom;
                this.comboBoxSousFamille.SelectedValue = article.SousFamille.Nom;
                String prix = article.PrixHT.ToString();
                this.textBoxPrixHT.Text = prix.Replace(",", ".");
                this.textBoxQuantite.Text = article.Quantite.ToString();

            }
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Boolean IsArticleRefTaken = MeinController.IsArticleRefTaken(this.textBoxRefArticle.Text);
            if ((new Regex(@"^\d*\.?\d*$")).IsMatch(textBoxPrixHT.Text) && (new Regex(@"^[0-9]\d*$")).IsMatch(textBoxQuantite.Text))
            {
                if (RefArticle == null)
                {
                    if (!IsArticleRefTaken)
                    {
                        MeinController.InsertArticle(this.textBoxRefArticle.Text, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedValue.ToString(), this.comboBoxMarque.SelectedValue.ToString(), float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(this.textBoxQuantite.Text));
                        MessageBox.Show("Article Ajouté");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Cette référence est déjà prise par un autre article");
                    }
                }
                else
                { 
                    MeinController.UpdateArticle(this.textBoxRefArticle.Text, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedValue.ToString(), this.comboBoxMarque.SelectedValue.ToString(), float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(this.textBoxQuantite.Text));
                    MessageBox.Show("Article Modifié");
                    this.Dispose();
                }  
            }
            else
            {
                MessageBox.Show("Veuillez à ce que le prix unitaire soit un nombre décimale positif et que la quantité soit un entier positif");
            }

}
    }
}
