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
        private SousFamille SousFamille;
        public FormAddModifSousFamille(SousFamille SousFamille)
        {
            InitializeComponent();
            this.SousFamille = SousFamille;
            if (SousFamille != null)
            {
                this.Text = "Modification SousFamille";
            }
            this.comboBoxFamille.DataSource = MeinController.GetAllFamilles();
            this.comboBoxFamille.DisplayMember = "nom";
            this.comboBoxFamille.ValueMember = "refFamille";
            this.comboBoxFamille.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
