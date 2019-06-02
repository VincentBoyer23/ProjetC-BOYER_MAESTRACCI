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
        public FormAddModifSousFamille(int RefSousFamille)
        {
            InitializeComponent();
            this.RefSousFamille = RefSousFamille;
            if (RefSousFamille>0)
            {
                this.Text = "Modification SousFamille";
            }
            this.comboBoxFamille.DataSource = MeinController.GetAllFamilles();
            this.comboBoxFamille.DisplayMember = "nom";
            this.comboBoxFamille.ValueMember = "nom";
            this.comboBoxFamille.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            Boolean IsSousFamilleNameTaken = MeinController.IsSousFamilleNameTaken(this.textBoxName.Text);
            if (this.RefSousFamille < 0)
            {
                if (!IsSousFamilleNameTaken)
                {
                    MeinController.InsertSousFamille(this.textBoxName.Text, this.comboBoxFamille.SelectedText);
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
                    MeinController.UpdateSousFamille(this.RefSousFamille, this.textBoxName.Text, this.comboBoxFamille.SelectedText);
                }
                else
                {
                    MessageBox.Show("Cette SousFamille existe déjà");
                }

            }
        }
    }
}
