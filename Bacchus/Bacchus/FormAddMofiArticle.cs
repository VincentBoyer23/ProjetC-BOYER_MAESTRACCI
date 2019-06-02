using Bacchus.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formforproject
{
    
    public partial class FormAddMofiArticle : Form
    {
        private String RefArticle;
        public FormAddMofiArticle(String RefArticle)
        {
            InitializeComponent();
            this.RefArticle = RefArticle;
            if (MeinController.IsArticleRefTaken(RefArticle))
            {
                this.Text = "Modification SousFamille";
            }
            this.comboBoxSousFamille.DataSource = MeinController.GetAllSousFamilles();
            this.comboBoxSousFamille.DisplayMember = "nom";
            this.comboBoxSousFamille.ValueMember = "nom";
            this.comboBoxSousFamille.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMarque.DataSource = MeinController.GetAllMarques();
            this.comboBoxMarque.DisplayMember = "nom";
            this.comboBoxMarque.ValueMember = "nom";
            this.comboBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!MeinController.IsArticleRefTaken(RefArticle))
            {
                    MeinController.InsertArticle(this.RefArticle, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedText, this.comboBoxMarque.SelectedText, float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat) , Convert.ToInt32(this.textBoxQuantite.Text));
            }
            else
            {
                    MeinController.UpdateArticle(this.RefArticle, this.richTextBoxDesc.Text, this.comboBoxSousFamille.SelectedText, this.comboBoxMarque.SelectedText, float.Parse(this.textBoxPrixHT.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(this.textBoxQuantite.Text));
            }

        }
    }
}
