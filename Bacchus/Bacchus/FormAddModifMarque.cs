using Bacchus;
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
    public partial class FormAddModifMarque : Form
    {
        private Marque Marque;
        public FormAddModifMarque(Marque Marque)
        {
            InitializeComponent();
            this.Marque = Marque;
            if (Marque != null)
            {
                this.Text = "Modification Marque";
            }
        }
        /// <summary>
        /// Ajoute/mofifie une Marque ou renvoie un message si le nom de la marque est déjà utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (this.Marque != null)
            {
                Marque NewMarque = DBManager.getMarqueByName(this.Marque.Nom);
                if (NewMarque == null)
                {
                    DBManager.insertMarque(this.Marque);
                }
                else
                {
                    MessageBox.Show("Cette marque existe déjà");
                }
            }
            else
            {
                Marque NewMarque = DBManager.getMarqueByName(this.textBoxName.Text);
                if (NewMarque == null)
                {
                    NewMarque = new Marque();
                    NewMarque.Nom = this.textBoxName.Text;
                    DBManager.insertMarque(NewMarque);
                }
                else
                {
                    MessageBox.Show("Cette marque existe déjà");
                }

            }

        }
    }
}
