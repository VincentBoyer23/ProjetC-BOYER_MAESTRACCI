using Bacchus.Controller;
using Bacchus.Model;
using formforproject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bacchus
{
    enum ListTypes
    {
        Article,
        Marque,
        Famille,
        SousFamille
    }

    // Compares two ListView items based on a selected column.

    public partial class FormMain : Form
    {
        
        ListTypes CurrentType = ListTypes.Article;
        private ColumnHeader SortingColumn = null;

        /// <summary>
        /// Constructeur fenêtre.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();


            // Replace la fenêtre au même endroit
            object SettingLeft = Bacchus.Properties.Settings.Default.Left;
            object SettingTop = Bacchus.Properties.Settings.Default.Top;
           

            if (SettingLeft != null && SettingLeft is int && SettingTop != null && SettingTop is int)
            {
                this.Left = (int)SettingLeft;
                this.Top = (int)SettingTop;
            }

            splitContainer1.Panel1MinSize = 200;
            InitListViews();
            MajListViews();
            UpdateStatus();

        }



        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Affiche la fenêtre d'import de fichier csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportCSV FormCSV = new FormImportCSV();
            FormCSV.ShowDialog();
            UpdateStatus();
        }


        /// <summary>
        /// Initialise les différentes vues possibles.
        /// </summary>
        public void InitListViews()
        {

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.ContextMenuStrip = ContextMenuListView;

        }



        /// <summary>
        /// Met la ListView dans le mode correspondant au type courrant. 
        /// </summary>
        public void MajListViews()
        {
            switch (CurrentType)
            {
                case ListTypes.Article:
                    MajArticles();
                    break;
                case ListTypes.Famille:
                    MajFamille();
                    break;
                case ListTypes.SousFamille:
                    MajSousFamille();
                    break;
                case ListTypes.Marque:
                    MajMarques();
                    break;
                default: break;
            }
        }


        /// <summary>
        /// Met la ListView en mode Article.
        /// </summary>
        public void MajArticles()
        {
            listView1.Clear();
            listView1.Columns.Add("Référence");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("Marque");
            listView1.Columns.Add("Famille");
            listView1.Columns.Add("Sous Famille");
            listView1.Columns.Add("Prix HT");
            listView1.Columns.Add("Quantité");
            List<Article> Articles = MainController.GetAllArticles();
            ListViewItem ItemView;
            string[] Arr;
            foreach (Article Article in Articles)
            {

                Arr = new string[7];
                Arr[0] = Article.RefArticle;
                Arr[1] = Article.Description;
                Arr[2] = Article.Marque.Nom;
                Arr[3] = Article.SousFamille.Famille.Nom;
                Arr[4] = Article.SousFamille.Nom;
                Arr[5] = Article.PrixHT.ToString();
                Arr[6] = Article.Quantite.ToString();
                ItemView = new ListViewItem(Arr);
                listView1.Items.Add(ItemView);

            }
        }

        /// <summary>
        /// Met la ListView en mode Marque.
        /// </summary>
        public void MajMarques()
        {
            listView1.Clear();
            listView1.Columns.Add("Référence");
            listView1.Columns.Add("Nom");
            List<Marque> Marques = MainController.GetAllMarques();
            ListViewItem ItemView;
            string[] Arr;
            foreach (Marque Marque in Marques)
            {

                Arr = new string[2];
                Arr[0] = Marque.RefMarque.ToString();
                Arr[1] = Marque.Nom;

                ItemView = new ListViewItem(Arr);
                listView1.Items.Add(ItemView);

            }
        }

        /// <summary>
        /// Met la ListView en mode Famille.
        /// </summary>
        public void MajFamille()
        {
            listView1.Clear();
            listView1.Columns.Add("Référence");
            listView1.Columns.Add("Nom");
            List<Famille> Familles = MainController.GetAllFamilles();
            ListViewItem ItemView;
            string[] Arr;
            foreach (Famille Famille in Familles)
            {

                Arr = new string[2];
                Arr[0] = Famille.RefFamille.ToString();
                Arr[1] = Famille.Nom;

                ItemView = new ListViewItem(Arr);
                listView1.Items.Add(ItemView);

            }
        }

        /// <summary>
        /// Met la ListView en mode SousFamille.
        /// </summary>
        public void MajSousFamille()
        {
            listView1.Clear();
            listView1.Columns.Add("Référence");
            listView1.Columns.Add("Nom");
            listView1.Columns.Add("Famille");
            List<SousFamille> SousFamilles = MainController.GetAllSousFamilles();
            ListViewItem ItemView;
            string[] Arr;
            foreach (SousFamille SousFamille in SousFamilles)
            {

                Arr = new string[3];
                Arr[0] = SousFamille.RefSousFamille.ToString();
                Arr[1] = SousFamille.Nom;
                Arr[2] = SousFamille.Famille.Nom;

                ItemView = new ListViewItem(Arr);
                listView1.Items.Add(ItemView);

            }
        }
        /// <summary>
        /// Affiche la fenêtre d'export de fichier csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportCSV FormCSV = new FormExportCSV();
            FormCSV.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenModifElementWindow();
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItemFromList();
        }


        /// <summary>
        /// Retourne la valeur de l'élémente selectionné de la ListView.
        /// </summary>
        /// <returns></returns>
        private string GetSelectedIdValue()
        {
            return listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewElementWindow();
        }


        /// <summary>
        /// Handles the KeyDown event of the List_View_Articles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void ListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MajListViews();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteItemFromList();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                OpenModifElementWindow();
            }
        }
        /// <summary>
        /// Change le type d'éléments en fonction du TreeView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int Pos = TreeView.SelectedNode.Index;
            switch (Pos)
            {
                case 0:
                    CurrentType = ListTypes.Article;
                    break;
                case 1:
                    CurrentType = ListTypes.Marque;
                    break;
                case 2:
                    CurrentType = ListTypes.Famille;
                    break;
                case 3:
                    CurrentType = ListTypes.SousFamille;
                    break;
                default:
                    CurrentType = ListTypes.Article;
                    break;
            }

            MajListViews();

        }


        /// <summary>
        /// Trie la liste après clic sur une colonne
        /// </summary>
        /// <remarks>
        /// Code from http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listView1.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            // Create a comparer.
            listView1.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listView1.Sort();
        }


        /// <summary>
        /// Supprime l'élément sélectionné.
        /// </summary>
        private void DeleteItemFromList()
        {

            DialogResult dr = MessageBox.Show("Êtes-vous sur de vouloir supprimer cet élément?", "Suppression", MessageBoxButtons.OKCancel,
   MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                string Ref = GetSelectedIdValue();
                switch (CurrentType)
                {
                    case ListTypes.Article:
                        MainController.DeleteArticle(Ref);
                        break;
                    case ListTypes.Famille:
                        MainController.DeleteFamille(Int32.Parse(Ref));
                        break;
                    case ListTypes.SousFamille:
                        MainController.DeleteSousFamille(Int32.Parse(Ref));
                        break;
                    case ListTypes.Marque:
                        MainController.DeleteMarque(Int32.Parse(Ref));
                        break;
                    default: break;
                }
                MajListViews();
                UpdateStatus();
            }

        }


        /// <summary>
        /// Ouvre une fenêtre de modification pour l'objet selectionné.
        /// </summary>
        private void OpenModifElementWindow()
        {
            string Ref = GetSelectedIdValue();
            Form Form;
            switch (CurrentType)
            {
                case ListTypes.Article:
                    Form = new FormAddModifArticle(Ref);
                    break;
                case ListTypes.Famille:
                    Form = new FormAddModifFamille(Int32.Parse(Ref));
                    break;
                case ListTypes.SousFamille:
                    Form = new FormAddModifSousFamille(Int32.Parse(Ref));
                    break;
                case ListTypes.Marque:
                    Form = new FormAddModifMarque(Int32.Parse(Ref));
                    break;
                default:
                    Form = null;
                    break;
            }
            Form.ShowDialog();
            MajListViews();
            UpdateStatus();
        }


        /// <summary>
        /// Ouvre une fenêtre de création d'un nouvel élément.
        /// </summary>
        private void OpenNewElementWindow()
        {
            Form Form;
            switch (CurrentType)
            {
                case ListTypes.Article:
                    Form = new FormAddModifArticle(null);
                    break;
                case ListTypes.Famille:
                    Form = new FormAddModifFamille(-1);
                    break;
                case ListTypes.SousFamille:
                    Form = new FormAddModifSousFamille(-1);
                    break;
                case ListTypes.Marque:
                    Form = new FormAddModifMarque(-1);
                    break;
                default:
                    Form = null;
                    break;
            }
            Form.ShowDialog();
            MajListViews();
            UpdateStatus();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bacchus.Properties.Settings.Default.Left= this.Left;
            Bacchus.Properties.Settings.Default.Top = this.Top;
            Bacchus.Properties.Settings.Default.Save();
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            OpenModifElementWindow();
        }

        private void UpdateStatus()
        {
            toolStripStatusLabel.Text = MainController.GetNbArticles().ToString() + " article(s) dans la BDD";
        }
    }
}
