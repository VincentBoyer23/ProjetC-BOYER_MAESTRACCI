using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bacchus.Model;

namespace Bacchus.Controller
{
    class MeinController
    {

        public static void InsertFamille(String NomFamille)
        {
            Famille Famille = new Famille();
            Famille.Nom = NomFamille;
            DBManager.InsertFamille(Famille);

        }
        public static void UpdateFamille(int RefFamille, String NomFamille)
        {
            Famille Famille = new Famille();
            Famille.RefFamille = RefFamille;
            Famille.Nom = NomFamille;
            DBManager.UpdateFamille(Famille);

        }
        public static void DeleteFamille(int RefFamille)
        {
            DBManager.DeleteFamilleByRef(RefFamille);

        }

        public static void InsertSousFamille(String NomSousFamille, String NomFamille)
        {
            Famille Famille = DBManager.GetFamilleByName(NomFamille);
            SousFamille SousFamille = new SousFamille();
            SousFamille.Nom = NomSousFamille;
            SousFamille.Famille = Famille;
            DBManager.InsertSousFamille(SousFamille);

        }

        public static void UpdateSousFamille(int RefSousFamille, String NomSousFamille, String NomFamille)
        {
            Famille Famille = DBManager.GetFamilleByName(NomFamille);
            SousFamille SousFamille = new SousFamille();

            SousFamille.Nom = NomSousFamille;
            SousFamille.Famille = Famille;
            DBManager.InsertSousFamille(SousFamille);

        }
        public static void DeleteSousFamille(int RefSousFamille)
        {
            DBManager.DeleteSousFamilleByRef(RefSousFamille);

        }
        public static void InsertMarque(String nomMarque)
        {
            Marque marque = new Marque();
            marque.Nom = nomMarque;
            DBManager.InsertMarque(marque);

        }
        public static void UpdateMarque(int RefMarque, String NomMarque)
        {
            Marque Marque = new Marque();
            Marque.RefMarque = RefMarque;
            Marque.Nom = NomMarque;
            DBManager.InsertMarque(Marque);

        }

        public static void DeleteMarque(int RefMarque)
        {
            DBManager.DeleteMarqueByRef(RefMarque);

        }

        public static void PourJérusalem()
        {
            DBManager.MajRef();
        }
        public static int DEUSVULT()
        {
            return DBManager.WIPEOUT();
        }

        public static bool InsertArticleForCSVImport(String RefArticle, String Description, String NomFamille, String NomSousFamille, String NomMarque, float PrixHT, int Quantite )
        {
            Marque marque = DBManager.GetMarqueByName(NomMarque);
            if(marque == null)
            {
                marque = new Marque();
                marque.Nom = NomMarque;
                DBManager.InsertMarque(marque);
            }

            

            SousFamille sousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            if(sousFamille == null)
            {
                Famille famille = DBManager.GetFamilleByName(NomFamille);
                if (famille == null)
                {
                    famille = new Famille();
                    famille.Nom = NomFamille;
                    DBManager.InsertFamille(famille);
                }
                sousFamille = new SousFamille();
                sousFamille.Nom = NomSousFamille;
                sousFamille.Famille = famille;
                DBManager.InsertSousFamille(sousFamille);
            }
            Article article = new Article();
            article.Description = Description;
            article.SousFamille = sousFamille;
            article.RefArticle = RefArticle;
            article.Marque = marque;
            article.PrixHT = PrixHT;
            article.Quantite = Quantite;
            return DBManager.InsertArticle(article);

        }

        /// <summary>
        /// Ajoute un article dans la base de donnée. Différent de InsertArticleForCSVImport() car nous n'avons pas besoin de vérifier si chaque 
        /// famille, sousfamille, marque existes (Elles existent forcement car le choix par l'utilisateur se fait par des combobox chargées à partir
        /// de la BDD.
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <param name="Description"></param>
        /// <param name="NomSousFamille"></param>
        /// <param name="NomMarque"></param>
        /// <param name="PrixHT"></param>
        /// <param name="Quantite"></param>
        /// <returns></returns>
        public static bool InsertArticle(String RefArticle, String Description, String NomSousFamille, String NomMarque, float PrixHT, int Quantite)
        {
            Marque marque = DBManager.GetMarqueByName(NomMarque);
            SousFamille sousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            Article article = new Article();
            article.Description = Description;
            article.SousFamille = sousFamille;
            article.RefArticle = RefArticle;
            article.Marque = marque;
            article.PrixHT = PrixHT;
            article.Quantite = Quantite;
            return DBManager.InsertArticle(article);
        }
        public static bool UpdateArticle(String RefArticle, String Description, String NomSousFamille, String NomMarque, float PrixHT, int Quantite)
        {
            Marque marque = DBManager.GetMarqueByName(NomMarque);
            SousFamille sousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            Article article = new Article();
            article.Description = Description;
            article.SousFamille = sousFamille;
            article.RefArticle = RefArticle;
            article.Marque = marque;
            article.PrixHT = PrixHT;
            article.Quantite = Quantite;
            return DBManager.UpdateArticle(article);
        }

        public static void DeleteArticle(String RefArticle)
        {
            DBManager.DeleteArticleByRef(RefArticle);

        }
        public static List<Famille> GetAllFamilles()
        {
            return DBManager.GetAllFamilles();
        }
        public static List<SousFamille> GetAllSousFamilles()
        {
            return DBManager.GetAllSousFamilles();
        }
        public static List<Marque> GetAllMarques()
        {
            return DBManager.GetAllMarques();
        }

        public static List<Article> GetAllArticles()
        {
            return DBManager.GetAllArticles();
        }

        public static Boolean IsFamilleNameTaken(String Name)
        {
            Famille TempFamille = DBManager.GetFamilleByName(Name);
            if (TempFamille == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean IsMarqueNameTaken(String Name)
        {
            Marque TempMarque = DBManager.GetMarqueByName(Name);
            if (TempMarque == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean IsSousFamilleNameTaken(String Name)
        {
            SousFamille TempSousFamille = DBManager.GetSousFamilleByName(Name);
            if (TempSousFamille == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean IsArticleRefTaken(String RefArticle)
        {
            Article TempArticle = DBManager.GetArticleByRef(RefArticle);
            if (TempArticle == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
