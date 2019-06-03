using System;
using System.Collections.Generic;
using Bacchus.Model;

namespace Bacchus.Controller
{
    class MainController
    {

        /// <summary>
        /// Insere une nouvelle Famille dans la BDD.
        /// </summary>
        /// <param name="NomFamille">le nom de la famille</param>
        public static void InsertFamille(String NomFamille)
        {
            Famille Famille = new Famille();
            Famille.Nom = NomFamille;
            DBManager.InsertFamille(Famille);

        }

        /// <summary>
        /// Met à jour une famille dans la BDD.
        /// </summary>
        /// <param name="RefFamille">la référence de la famille à supprimer.</param>
        /// <param name="NomFamille">le nouveau nom de la famille</param>
        public static void UpdateFamille(int RefFamille, String NomFamille)
        {
            Famille Famille = new Famille();
            Famille.RefFamille = RefFamille;
            Famille.Nom = NomFamille;
            DBManager.UpdateFamille(Famille);

        }

        /// <summary>
        /// Supprime la famille de la BDD.
        /// </summary>
        /// <param name="RefFamille">La référence de la famille a supprimé.</param>
        public static void DeleteFamille(int RefFamille)
        {
            DBManager.DeleteFamilleByRef(RefFamille);

        }

        /// <summary>
        /// Insère une nouvelle sous famille
        /// </summary>
        /// <param name="NomSousFamille">Nom de la sous famille.</param>
        /// <param name="NomFamille">Nom de la famille.</param>
        public static void InsertSousFamille(String NomSousFamille, String NomFamille)
        {
            Famille Famille = DBManager.GetFamilleByName(NomFamille);
            SousFamille SousFamille = new SousFamille();
            SousFamille.Nom = NomSousFamille;
            SousFamille.Famille = Famille;
            DBManager.InsertSousFamille(SousFamille);

        }
        
        /// <summary>
        /// Met à jour une sous famille.
        /// </summary>
        /// <param name="RefSousFamille"></param>
        /// <param name="NomSousFamille"></param>
        /// <param name="NomFamille"></param>
        public static void UpdateSousFamille(int RefSousFamille, String NomSousFamille, String NomFamille)
        {
            Famille Famille = DBManager.GetFamilleByName(NomFamille);
            SousFamille SousFamille = new SousFamille();
            SousFamille.RefSousFamille = RefSousFamille;
            SousFamille.Nom = NomSousFamille;
            SousFamille.Famille = Famille;
            DBManager.UpdateSousFamille(SousFamille);

        }

        /// <summary>
        /// Retourne le nombre d'articles dans la BDD.
        /// </summary>
        /// <returns></returns>
        public static int GetNbArticles()
        {
            return DBManager.GetNbArticles();
        }

        /// <summary>
        /// Supprime une sous famille.
        /// </summary>
        /// <param name="RefSousFamille"></param>
        public static void DeleteSousFamille(int RefSousFamille)
        {
            DBManager.DeleteSousFamilleByRef(RefSousFamille);

        }

        /// <summary>
        /// Insère une nouvelle Marque.
        /// </summary>
        /// <param name="NomMarque"></param>
        public static void InsertMarque(String NomMarque)
        {
            Marque Marque = new Marque();
            Marque.Nom = NomMarque;
            DBManager.InsertMarque(Marque);

        }

        /// <summary>
        /// Met à jour la marque.
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <param name="NomMarque"></param>
        public static void UpdateMarque(int RefMarque, String NomMarque)
        {
            Marque Marque = new Marque();
            Marque.RefMarque = RefMarque;
            Marque.Nom = NomMarque;
            DBManager.UpdateMarque(Marque);

        }


        /// <summary>
        /// Supprime une marque.
        /// </summary>
        /// <param name="RefMarque"></param>
        public static void DeleteMarque(int RefMarque)
        {
            DBManager.DeleteMarqueByRef(RefMarque);

        }

        /// <summary>
        /// Met à jour les références de la BDD.
        /// </summary>
        public static void MajRefs()
        {
            DBManager.MajRef();
        }

        /// <summary>
        /// Purge la BDD de toutes données.
        /// </summary>
        /// <returns></returns>
        public static int PurgeBDD()
        {
            return DBManager.PurgeBDD();
        }

        /// <summary>
        /// Insére un nouvel article dans la BDD depuis 
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <param name="Description"></param>
        /// <param name="NomFamille"></param>
        /// <param name="NomSousFamille"></param>
        /// <param name="NomMarque"></param>
        /// <param name="PrixHT"></param>
        /// <param name="Quantite"></param>
        /// <returns></returns>
        public static bool InsertArticleForCSVImport(String RefArticle, String Description, String NomFamille, String NomSousFamille, String NomMarque, float PrixHT, int Quantite )
        {
            Marque marque = DBManager.GetMarqueByName(NomMarque);
            if(marque == null)
            {
                marque = new Marque();
                marque.Nom = NomMarque;
                DBManager.InsertMarque(marque);
            }

            
            SousFamille SousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            if(SousFamille == null)
            {
                Famille Famille = DBManager.GetFamilleByName(NomFamille);
                if (Famille == null)
                {
                    Famille = new Famille();
                    Famille.Nom = NomFamille;
                    DBManager.InsertFamille(Famille);
                }
                SousFamille = new SousFamille();
                SousFamille.Nom = NomSousFamille;
                SousFamille.Famille = Famille;
                DBManager.InsertSousFamille(SousFamille);
            }
            Article Article = new Article();
            Article.Description = Description;
            Article.SousFamille = SousFamille;
            Article.RefArticle = RefArticle;
            Article.Marque = marque;
            Article.PrixHT = PrixHT;
            Article.Quantite = Quantite;
            return DBManager.InsertArticle(Article);

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
            Marque Marque = DBManager.GetMarqueByName(NomMarque);
            SousFamille SousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            Article Article = new Article();
            Article.Description = Description;
            Article.SousFamille = SousFamille;
            Article.RefArticle = RefArticle;
            Article.Marque = Marque;
            Article.PrixHT = PrixHT;
            Article.Quantite = Quantite;
            return DBManager.InsertArticle(Article);
        }

        /// <summary>
        /// Met à jour un article dans la BDD.
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <param name="Description"></param>
        /// <param name="NomSousFamille"></param>
        /// <param name="NomMarque"></param>
        /// <param name="PrixHT"></param>
        /// <param name="Quantite"></param>
        /// <returns></returns>
        public static bool UpdateArticle(String RefArticle, String Description, String NomSousFamille, String NomMarque, float PrixHT, int Quantite)
        {
            Marque Marque = DBManager.GetMarqueByName(NomMarque);
            SousFamille SousFamille = DBManager.GetSousFamilleByName(NomSousFamille);
            Article Article = new Article();
            Article.Description = Description;
            Article.SousFamille = SousFamille;
            Article.RefArticle = RefArticle;
            Article.Marque = Marque;
            Article.PrixHT = PrixHT;
            Article.Quantite = Quantite;
            return DBManager.UpdateArticle(Article);
        }

        /// <summary>
        /// Supprime un article de la BDD.
        /// </summary>
        /// <param name="RefArticle"></param>
        public static void DeleteArticle(String RefArticle)
        {
            DBManager.DeleteArticleByRef(RefArticle);

        }

        /// <summary>
        /// Récupère l'ensemble des familles de la BDD.
        /// </summary>
        /// <returns></returns>
        public static List<Famille> GetAllFamilles()
        {
            return DBManager.GetAllFamilles();
        }

        /// <summary>
        /// Récupère une famille.
        /// </summary>
        /// <param name="RefFamille"></param>
        /// <returns></returns>
        public static Famille GetFamilleByRef(int RefFamille)
        {
            return DBManager.GetFamilleByRef(RefFamille);
        }

        /// <summary>
        /// Récupère l'ensemble des Sous Familles.
        /// </summary>
        /// <returns></returns>
        public static List<SousFamille> GetAllSousFamilles()
        {
            return DBManager.GetAllSousFamilles();
        }

        /// <summary>
        /// Récupère une Sous Famille
        /// </summary>
        /// <param name="RefSousFamille"></param>
        /// <returns></returns>
        public static SousFamille GetSousFamilleByRef(int RefSousFamille)
        {
            return DBManager.GetSousFamilleByRef(RefSousFamille);
        }

        /// <summary>
        /// Récupère l'ensemble des marques.
        /// </summary>
        /// <returns></returns>
        public static List<Marque> GetAllMarques()
        {
            return DBManager.GetAllMarques();
        }

        /// <summary>
        /// Récupère une Marque.
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <returns></returns>
        public static Marque GetMarqueByRef(int RefMarque)
        {
            return DBManager.GetMarqueByRef(RefMarque);
        }

        /// <summary>
        /// Récupère l'ensemble des articles.
        /// </summary>
        /// <returns></returns>
        public static List<Article> GetAllArticles()
        {
            return DBManager.GetAllArticles();
        }


        /// <summary>
        /// Récupère un article.
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <returns></returns>
        public static Article GetArticleByRef(String RefArticle)
        {
            return DBManager.GetArticleByRef(RefArticle);
        }


        /// <summary>
        /// Check si le nom de la Famille est pris.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Check si le nom de la marque est pris.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Check si le nom de la sous famille est pris.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Check si la référence de l'article existe déjà.
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <returns></returns>
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
