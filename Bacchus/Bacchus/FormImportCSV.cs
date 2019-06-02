using Bacchus.Controller;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Bacchus
{
    public partial class FormImportCSV : Form
    {
        int countCurrentFile;
        public FormImportCSV()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ajoute les données du fichier csv sans supprimer les données déjà existante dans la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            addToBDD();
        }
        /// <summary>
        /// ouvre la fenêtre permettant de sélectionner un fichier csv à importer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFileForm_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "fichier csv |*.csv";
                opf.ShowDialog();
                var filename = opf.FileName;
                textBoxFileName.Text = filename;
                using (StreamReader sr = new StreamReader(filename))
                {
                    int count = 0;
                    while ((sr.ReadLine()) != null)
                    {
                        count++;
                    }
                    countCurrentFile = count;
                    opf.Dispose();
                }

            }

        }

        private void FormImportCSV_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ajoute les données du fichier csv en supprimant les données déjà existante dans la BDD et réinitialise les références
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWipeAddDB_Click(object sender, EventArgs e)
        {
            textBoxLog.AppendText("c'est la purge, cachez-vous, "+MeinController.DEUSVULT()+ " rows deleted\r\n\r\n");
            MeinController.PourJérusalem();
            addToBDD();
        }
        /// <summary>
        /// Ajoute ls données contenues dans le fichier csv en base de donnée, elle remplit la textBoxLog et incrément la progress bar
        /// </summary>
        private void addToBDD()
        {
            var fileName = textBoxFileName.Text;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] columns = new string[6];
                bool firstLine = true;
                progressBarImport.Maximum = countCurrentFile - 1;
                progressBarImport.Value = 0;
                int success = 0, failure = 0;
                while ((line = sr.ReadLine()) != null)
                {

                    
                    columns = line.Split(';');
                    if (!firstLine)
                    {

                        var inserted = MeinController.InsertArticleForCSVImport(columns[1], columns[0], columns[3], columns[4], columns[2], float.Parse(columns[5]), 0);
                        if (inserted) success++;
                        else failure++ ;

                        progressBarImport.Value++;
                        textBoxLog.AppendText("Article ajoutée : " + columns[1] + "  " + columns[0] + "\r\n\r\n");
                    }
                    else
                    {
                        firstLine = false;
                    }

                }

                textBoxLog.AppendText(success + " articles ajoutés avec succès, " + failure + " erreurs");
            }
        }
    }
}
