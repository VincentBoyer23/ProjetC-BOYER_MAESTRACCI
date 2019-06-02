using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formforproject
{
    public partial class FormAddModifSousFamille : Form
    {
        private int RefSousFamille;
        private String NameSousFamille;
        public FormAddModifSousFamille(int RefSousFamille)
        {
            InitializeComponent();
            this.RefSousFamille = RefSousFamille;
            this.comboBoxFamille.DataSource = MeinController.GetAllFamilles();
            this.comboBoxFamille.DisplayMember = "nom";
            this.comboBoxFamille.ValueMember = "nom";
            this.comboBoxFamille.DropDownStyle = ComboBoxStyle.DropDownList;
            if (RefSousFamille>0)
            {
                SousFamille SousFamille = MeinController.GetSousFamilleByRef(RefSousFamille);
                this.Text = "Modification SousFamille";
                this.textBoxName.Text = SousFamille.Nom;
                NameSousFamille = SousFamille.Nom;
                this.comboBoxFamille.SelectedValue = SousFamille.Famille.Nom;
                
            }
            
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            Boolean IsSousFamilleNameTaken = MeinController.IsSousFamilleNameTaken(this.textBoxName.Text);
            if (this.RefSousFamille < 0)
            {
                if (!IsSousFamilleNameTaken)
                {
                    MeinController.InsertSousFamille(this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
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
                    MeinController.UpdateSousFamille(this.RefSousFamille, this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
                }
                else
                {
                    if(this.textBoxName.Text.Equals(NameSousFamille))
                    {
                        MeinController.UpdateSousFamille(this.RefSousFamille, this.textBoxName.Text, this.comboBoxFamille.SelectedValue.ToString());
                    }
                    else
                    MessageBox.Show("Cette SousFamille existe déjà");
                }

            }
        }
    }
}
