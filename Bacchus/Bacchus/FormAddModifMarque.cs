using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Windows.Forms;

namespace formforproject
{
    /// <summary>
    /// Formulaire création/modification marque.
    /// </summary>
    public partial class FormAddModifMarque : Form
    {
        private int RefMarque;
        private String NameMarque;

        /// <summary>
        /// Constructeur formulaire
        /// </summary>
        /// <param name="RefMarque"></param>
        public FormAddModifMarque(int RefMarque)
        {
            InitializeComponent();
            this.RefMarque = RefMarque;
            if (RefMarque>0)
            {
                Marque Marque = MainController.GetMarqueByRef(RefMarque);
                this.Text = "Modification Marque";
                this.textBoxName.Text = Marque.Nom;
                NameMarque = Marque.Nom;
            }
        }
        /// <summary>
        /// Ajoute/mofifie une Marque ou renvoie un message si le nom de la marque est déjà utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Boolean IsMarqueNameTaken = MainController.IsMarqueNameTaken(this.textBoxName.Text);
            if (this.RefMarque < 0)
            {
                if (!IsMarqueNameTaken)
                {
                    MainController.InsertMarque(this.textBoxName.Text);
                    MessageBox.Show("Marque Ajoutée");
                    this.Dispose();
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
                    MainController.UpdateMarque(this.RefMarque, this.textBoxName.Text);
                    MessageBox.Show("Marque Modifiée");
                    this.Dispose();
                }
                else
                {
                    if (this.textBoxName.Text.Equals(NameMarque))
                    {
                        MainController.UpdateMarque(this.RefMarque, this.textBoxName.Text);
                        MessageBox.Show("Marque Modifiée");
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Cette Marque existe déjà");
                }

            }

        }
    }
}
