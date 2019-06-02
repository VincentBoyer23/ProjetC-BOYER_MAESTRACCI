using Bacchus;
using Bacchus.Controller;
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
        private int RefMarque;
        public FormAddModifMarque(int RefMarque)
        {
            InitializeComponent();
            this.RefMarque = RefMarque;
            if (RefMarque>0)
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
            Boolean IsMarqueNameTaken = MeinController.IsMarqueNameTaken(this.textBoxName.Text);
            if (this.RefMarque < 0)
            {
                if (!IsMarqueNameTaken)
                {
                    MeinController.InsertMarque(this.textBoxName.Text);
                }
                else
                {
                    MessageBox.Show("Cette Marque existe déjà");
                }
            }
            else
            {
                if (!IsMarqueNameTaken)
                {
                    MeinController.UpdateMarque(this.RefMarque, this.textBoxName.Text);
                }
                else
                {
                    MessageBox.Show("Cette Marque existe déjà");
                }

            }

        }
    }
}
