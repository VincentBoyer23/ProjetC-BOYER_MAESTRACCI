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

        public static void insertFamille(String nomFamille)
        {
            Famille f = new Famille();
            f.Nom = nomFamille;
            DBManager.insertFamille(f);

        }

        public static void insertSousFamille(String nomSousFamille, String nomFamille)
        {
            Famille famille = DBManager.getFamilleByName(nomFamille);
            SousFamille sousFamille = new SousFamille();
            sousFamille.Nom = nomSousFamille;
            sousFamille.Famille = famille;
            DBManager.insertSousFamille(sousFamille);

        }

        public static void insertMarque(String nomMarque)
        {
            Marque marque = new Marque();
            marque.Nom = nomMarque;
            DBManager.insertMarque(marque);

        }


        public static void PourJérusalem()
        {
            DBManager.MajRef();
        }
        public static int DEUSVULT()
        {
            return DBManager.WIPEOUT();
        }

        public static bool insertArticle(String refArticle, String description, String nomFamille, String nomSousFamille, String nomMarque, float prixHT, int quantite )
        {
            Marque marque = DBManager.getMarqueByName(nomMarque);
            if(marque == null)
            {
                marque = new Marque();
                marque.Nom = nomMarque;
                DBManager.insertMarque(marque);
            }

            

            SousFamille sousFamille = DBManager.getSousFamilleByName(nomSousFamille);
            if(sousFamille == null)
            {
                Famille famille = DBManager.getFamilleByName(nomFamille);
                if (famille == null)
                {
                    famille = new Famille();
                    famille.Nom = nomFamille;
                    DBManager.insertFamille(famille);
                }
                sousFamille = new SousFamille();
                sousFamille.Nom = nomSousFamille;
                sousFamille.Famille = famille;
                DBManager.insertSousFamille(sousFamille);
            }
            Article article = new Article();
            article.Description = description;
            article.SousFamille = sousFamille;
            article.RefArticle = refArticle;
            article.Marque = marque;
            article.PrixHT = prixHT;
            article.Quantite = quantite;
            return DBManager.insertArticle(article);

        }

        public static List<Famille> GetAllFamilles()
        {
            return DBManager.getAllFamilles();
        }

        public static List<Article> GetAllArticles()
        {
            return DBManager.getAllArticles();
        }

        public static Famille GetFamilleByName(String Name)
        {
            return DBManager.getFamilleByName(Name);
        }

        public static Marque GetMarqueByName(String Name)
        {
            return DBManager.getMarqueByName(Name);
        }
    }
}
