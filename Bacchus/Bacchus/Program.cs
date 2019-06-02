using formforproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /* Model.Famille f1 = new Model.Famille();
             f1.Nom = "Boyer";
             DBManager.insertFamille(f1);

             Model.SousFamille s1 = new Model.SousFamille();
             s1.Famille = f1;
             s1.Nom = "Ma Sous Famille";
             DBManager.insertSousFamille(s1);

             Model.Marque marc  = new Model.Marque();
             marc.Nom = "Marc";
             DBManager.insertMarque(marc);

             Model.Article aaaaaaaaaaaaaa = new Model.Article();
             aaaaaaaaaaaaaa.Marque = marc;
             aaaaaaaaaaaaaa.SousFamille = s1;
             aaaaaaaaaaaaaa.PrixHT = 10;
             aaaaaaaaaaaaaa.Quantite = 2;
             aaaaaaaaaaaaaa.RefArticle = "Mon article";
             aaaaaaaaaaaaaa.Description = "Ci-git ma description !";
             DBManager.insertArticle(aaaaaaaaaaaaaa);*/

            //HelperCSV.saveFromFile("Données à intégrer.csv", true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            /*Application.Run(new FormAddModifFamille(8));*/
            /*Application.Run(new FormAddModifMarque(31));*/
            /*Application.Run(new FormAddModifSousFamille(19));*/
            /*Application.Run(new FormAddModifArticle("F5223222"));*/
            //DBManager.MajRef();
            //Console.WriteLine(DBManager.nextRefFamille);

        }
    }
}
