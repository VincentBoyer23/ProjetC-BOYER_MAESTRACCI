using System;
using System.Collections.Generic;
using Bacchus.Controller;
using System.IO;
using System.Windows.Forms;
using Bacchus.Model;

namespace Bacchus
{
    public partial class FormExportCSV : Form
    {
        /// <summary>
        /// Constructeur fenêtre.
        /// </summary>
        public FormExportCSV()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ouvre la fenêtre permettant de choisir un fichier pour sauvegarder les données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFileForm_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {

                saveFileDialog1.Filter = "fichier csv |*.csv";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileName.Text = saveFileDialog1.FileName;
                }
            }
        }
        /// <summary>
        /// Exporte toutes les données dans le fichier csv choisie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            var fileName = textBoxFileName.Text;
            List<Article> articles = MainController.GetAllArticles();
            progressBarExport.Maximum = articles.Count;
            progressBarExport.Value = 0;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Description;Ref;Marque;Famille;Sous-Famille;Prix H.T.");
                foreach (Article article in articles)
                {
                    sw.WriteLine(article.toCSV());
                    progressBarExport.Value++;
                    textBoxLog.AppendText("Article ajoutée : " + article.Description  + "\r\n\r\n");
                }
            }
            textBoxLog.AppendText( articles.Count + " articles exportés");
        }
    }
}
