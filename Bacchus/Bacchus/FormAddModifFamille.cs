
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
        private Famille Famille;
        public FormAddModifFamille(Famille Famille)
        {
            InitializeComponent();
            this.Famille = Famille;
            if(Famille!=null)
            {
                this.Text = "Modification Famille";
            }

        }
        /// <summary>
        /// Ajoute/mofifie une Famille ou renvoie un message si le nom de la famille est déjà utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (this.Famille != null)
            {
                Famille NewFamille = MeinController.GetFamilleByName(this.Famille.Nom);
                if(NewFamille==null)
                {
                    MeinController.insertFamille(this.Famille);
                }
                else
                {
                    MessageBox.Show("Cette famille existe déjà");
                }
            }
            else
            {
                Famille NewFamille = DBManager.getFamilleByName(this.textBoxName.Text);
                if (NewFamille == null)
                {
                    NewFamille = new Famille();
                    NewFamille.Nom = this.textBoxName.Text;
                    DBManager.insertFamille(NewFamille);
                }
                else
                {
                    MessageBox.Show("Cette famille existe déjà");
                }

            }

        }
    }
}
