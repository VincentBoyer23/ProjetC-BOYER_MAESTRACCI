using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace formforproject
{
    /// <summary>
    /// Formulaire d'ajout/modification d'article.
    /// </summary>
    public partial class FormAddModifArticle : Form
    {
        private string RefArticle;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="RefArticle"></param>
        public FormAddModifArticle(String RefArticle)
        {
            InitializeComponent();
            this.RefArticle = RefArticle;
            this.comboBoxSousFamille.DataSource = MainController.GetAllSousFamilles();
            this.comboBoxSousFamille.DisplayMember = "nom";
            this.comboBoxSousFamille.ValueMember = "nom";
            this.comboBoxSousFamille.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMarque.DataSource = MainController.GetAllMarques();
            this.comboBoxMarque.DisplayMember = "nom";
            this.comboBoxMarque.ValueMember = "nom";
            this.comboBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList;
            if (RefArticle!=null)
            {
                Article article = MainController.GetArticleByRef(RefArticle);
                this.Text = "Modification Article";
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

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Boolean IsArticleRefTaken = MainController.IsArticleRefTaken(this.textBoxRefArticle.Text);
            if ((new Regex(@"^\d*\.?\d*$")).IsMatch(textBoxPrixHT.Text) && (new Regex(@"^[0-9]\d*$")).IsMatch(textBoxQuantite.Text))
            {
                if (RefArticle == null)
                {
                    if (!IsArticleRefTaken)
                    {
                        MainController.InsertArticle(this.textBoxRefArticle.Text, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedValue.ToString(), this.comboBoxMarque.SelectedValue.ToString(), float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(this.textBoxQuantite.Text));
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
                    MainController.UpdateArticle(this.textBoxRefArticle.Text, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedValue.ToString(), this.comboBoxMarque.SelectedValue.ToString(), float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(this.textBoxQuantite.Text));
                    MessageBox.Show("Article Modifié");
                    this.Dispose();
                }  
            }
            else
            {
                MessageBox.Show("Veillez à ce que le prix unitaire soit un nombre décimale positif et que la quantité soit un entier positif");
            }

}
    }
}
