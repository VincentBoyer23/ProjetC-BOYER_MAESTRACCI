
using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Windows.Forms;

namespace formforproject
{
    public partial class FormAddModifFamille : Form
    {
        private int RefFamille;
        private String NameFamille;

        /// <summary>
        /// Constructeur formulaire.
        /// </summary>
        /// <param name="RefFamille"></param>
        public FormAddModifFamille(int RefFamille)
        {
            InitializeComponent();
            this.RefFamille = RefFamille;
            if(RefFamille>0)
            {
                Famille Famille = MainController.GetFamilleByRef(RefFamille);
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
            Boolean IsFamilleNameTaken = MainController.IsFamilleNameTaken(this.textBoxName.Text);
           if (this.RefFamille<0)
            {
                if (!IsFamilleNameTaken)
                {
                    MainController.InsertFamille(this.textBoxName.Text);
                    MessageBox.Show("Famille Ajoutée");
                    this.Dispose();
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
                    MainController.UpdateFamille(this.RefFamille, this.textBoxName.Text);
                    MessageBox.Show("Famille Modifiée");
                    this.Dispose();
                }
                else
                {
                    if (this.textBoxName.Text.Equals(NameFamille))
                    {
                        MainController.UpdateFamille(this.RefFamille, this.textBoxName.Text);
                        MessageBox.Show("Famille Modifiée");
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Cette famille existe déjà");
                }

            }

        }
    }
}
