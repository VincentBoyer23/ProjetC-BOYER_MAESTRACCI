
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
    public partial class FormAddModifFamille : Form
    {
        private int RefFamille;
        private String NameFamille;
        public FormAddModifFamille(int RefFamille)
        {
            InitializeComponent();
            this.RefFamille = RefFamille;
            if(RefFamille>0)
            {
                Famille Famille = MeinController.GetFamilleByRef(RefFamille);
                this.Text = "Modification Famille";
                this.textBoxName.Text = Famille.Nom;
                NameFamille = Famille.Nom;
            }

        }
        /// <summary>
        /// Ajoute/mofifie une Famille ou renvoie un message si le nom de la famille est déjà utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Boolean IsFamilleNameTaken = MeinController.IsFamilleNameTaken(this.textBoxName.Text);
           if (this.RefFamille<0)
            {
                if (!IsFamilleNameTaken)
                {
                    MeinController.InsertFamille(this.textBoxName.Text);
                }
                else
                {
                    MessageBox.Show("Cette famille existe déjà");
                }
            }
            else
            {
                if (!IsFamilleNameTaken)
                {
                    MeinController.UpdateFamille(this.RefFamille, this.textBoxName.Text);
                }
                else
                {
                    if (this.textBoxName.Text.Equals(NameFamille))
                    {
                        MeinController.UpdateFamille(this.RefFamille, this.textBoxName.Text);
                    }
                    else
                        MessageBox.Show("Cette famille existe déjà");
                }

            }

        }
    }
}
