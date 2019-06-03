using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Windows.Forms;

namespace formforproject
{

    /// <summary>
    /// Formulaire création/modification sous famille.
    /// </summary>
    public partial class FormAddModifSousFamille : Form
    {
        private int RefSousFamille;
        private String NameSousFamille;

        /// <summary>
        /// Constructeur formulaire.
        /// </summary>
        /// <param name="RefSousFamille"></param>
        public FormAddModifSousFamille(int RefSousFamille)
        {
            InitializeComponent();
            this.RefSousFamille = RefSousFamille;
            this.comboBoxFamille.DataSource = MainController.GetAllFamilles();
            this.comboBoxFamille.DisplayMember = "nom";
            this.comboBoxFamille.ValueMember = "nom";
            this.comboBoxFamille.DropDownStyle = ComboBoxStyle.DropDownList;
            if (RefSousFamille>0)
            {
                SousFamille SousFamille = MainController.GetSousFamilleByRef(RefSousFamille);
                this.Text = "Modification SousFamille";
                this.textBoxName.Text = SousFamille.Nom;
                NameSousFamille = SousFamille.Nom;
                this.comboBoxFamille.SelectedValue = SousFamille.Famille.Nom;
                
            }
            
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            Boolean IsSousFamilleNameTaken = MainController.IsSousFamilleNameTaken(this.textBoxName.Text);
            if (this.RefSousFamille < 0)
            {
                if (!IsSousFamilleNameTaken)
                {
                    MainController.InsertSousFamille(this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
                    MessageBox.Show("SousFamille Ajoutée");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cette SousFamille existe déjà");
                }
            }
            else
            {
                if (!IsSousFamilleNameTaken)
                {
                    MainController.UpdateSousFamille(this.RefSousFamille, this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
                    MessageBox.Show("SousFamille Modifiée");
                    this.Dispose();
                }
                else
                {
                    if(this.textBoxName.Text.Equals(NameSousFamille))
                    {
                        MainController.UpdateSousFamille(this.RefSousFamille, this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
                        MessageBox.Show("SousFamille Modifiée");
                        this.Dispose();
                    }
                    else
                    MessageBox.Show("Cette SousFamille existe déjà");
                }

            }
        }
    }
}
