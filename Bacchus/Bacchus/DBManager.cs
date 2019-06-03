using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Bacchus.Model;
namespace Bacchus
{
    class DBManager
    {
        public static int NextRefFamille = 1;
        public static int NextRefSousFamille = 1;
        public static int NextRefMarque = 1;

        /// <summary>
        /// Ajoute une famille dans la BDD
        /// </summary>
        /// <param name="Famille"></param>
        /// <returns></returns>
        public static int InsertFamille(Famille Famille)
        {
            int Inserted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "INSERT INTO Familles(RefFamille, Nom) VALUES(@Ref, @Nom)";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", NextRefFamille);
            Cmd.Parameters.AddWithValue("@Nom", Famille.Nom);
            try
            {
                Inserted = Cmd.ExecuteNonQuery();
                if (Inserted > 0) Famille.RefFamille=NextRefFamille++;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Inserted;
        }

        /// <summary>
        /// Modifie une famille dans la BDD
        /// </summary>
        /// <param name="Famille"></param>
        /// <returns></returns>
        public static int UpdateFamille(Famille Famille)
        {
            int Updated = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "UPDATE Familles SET Nom = @Nom WHERE RefFamille = @Ref";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", Famille.RefFamille);
            Cmd.Parameters.AddWithValue("@Nom", Famille.Nom);
            try
            {
                Updated = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Updated;
        }

        /// <summary>
        /// Supprime une famille dans la BDD
        /// </summary>
        /// <param name="RefFamille"></param>
        /// <returns></returns>
        public static int DeleteFamilleByRef(int RefFamille)
        {
            int Deleted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "DELETE FROM Familles WHERE RefFamille = @Ref";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", RefFamille);
            try
            {
                Deleted = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Deleted;
        }

        /// <summary>
        /// Ajoute une SousFamille dans la BDD
        /// </summary>
        /// <param name="SousFamille"></param>
        /// <returns></returns>
        public static int InsertSousFamille(SousFamille SousFamille)
        {
            int Inserted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "INSERT INTO SousFamilles(RefSousFamille,RefFamille, Nom) VALUES(@Ref,@RefFamille, @Nom)";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", NextRefSousFamille);
            Cmd.Parameters.AddWithValue("@RefFamille", SousFamille.Famille.RefFamille);
            Cmd.Parameters.AddWithValue("@Nom", SousFamille.Nom);
            try
            {
                Inserted = Cmd.ExecuteNonQuery();
                if (Inserted > 0) SousFamille.RefSousFamille=NextRefSousFamille++;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Inserted;
        }

        /// <summary>
        /// Modifie une SousFamille dans la BDD
        /// </summary>
        /// <param name="SousFamille"></param>
        /// <returns></returns>
        public static int UpdateSousFamille(SousFamille SousFamille)
        {
            int Updated = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "UPDATE SousFamilles SET Nom = @Nom, RefFamille = @RefFamille WHERE RefSousFamille = @Ref ";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", SousFamille.RefSousFamille);
            Cmd.Parameters.AddWithValue("@RefFamille", SousFamille.Famille.RefFamille);
            Cmd.Parameters.AddWithValue("@Nom", SousFamille.Nom);
            try
            {
                Updated = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Updated;
        }
        /// <summary>
        /// Supprime une SousFamille de la BDD
        /// </summary>
        /// <param name="RefSousFamille"></param>
        /// <returns></returns>
        public static int DeleteSousFamilleByRef(int RefSousFamille)
        {
            int Deleted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "DELETE FROM SousFamilles WHERE RefSousFamille = @Ref";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", RefSousFamille);
            try
            {
                Deleted = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Deleted;
        }
        /// <summary>
        /// Ajoute une Marque dans la BDD
        /// </summary>
        /// <param name="Marque"></param>
        /// <returns></returns>
        public static int InsertMarque(Marque Marque)
        {
            int Inserted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "INSERT INTO Marques(RefMarque, Nom) VALUES(@Ref, @Nom)";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", NextRefMarque);
            Cmd.Parameters.AddWithValue("@Nom", Marque.Nom);
            try
            {
                Inserted = Cmd.ExecuteNonQuery();
                if (Inserted > 0) Marque.RefMarque = NextRefMarque++;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Inserted;
        }
        /// <summary>
        /// Modifie une Marque dans la BDD
        /// </summary>
        /// <param name="Marque"></param>
        /// <returns></returns>
        public static int UpdateMarque(Marque Marque)
        {
            int Updated = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "UPDATE Marques SET Nom = @Nom WHERE RefMarque = @Ref";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", Marque.RefMarque);
            Cmd.Parameters.AddWithValue("@Nom", Marque.Nom);
            try
            {
                Updated = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Updated;
        }
        /// <summary>
        /// Supprime une Marque de la BDD
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <returns></returns>
        public static int DeleteMarqueByRef(int RefMarque)
        {
            int Deleted = 0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "DELETE FROM Marques WHERE RefMarque = @Ref";
            Cmd.Prepare();
            Cmd.Parameters.AddWithValue("@Ref", RefMarque);
            try
            {
                Deleted = Cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Deleted;
        }
        /// <summary>
        /// Supprime toute les données de la BDD
        /// </summary>
        /// <returns></returns>
        public static int PurgeBDD()
        {
            int RowDeleted=0;
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "DELETE FROM Marques";
            RowDeleted += Cmd.ExecuteNonQuery();
            Cmd.CommandText = "DELETE FROM Articles";
            RowDeleted += Cmd.ExecuteNonQuery();
            Cmd.CommandText = "DELETE FROM Familles";
            RowDeleted += Cmd.ExecuteNonQuery();
            Cmd.CommandText = "DELETE FROM SousFamilles";
            RowDeleted += Cmd.ExecuteNonQuery();

            return RowDeleted;
        }
        /// <summary>
        /// Récupère une Famille par sa référence
        /// </summary>
        /// <param name="RefFamille"></param>
        /// <returns></returns>
        public static Famille GetFamilleByRef(int RefFamille)
        {
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "SELECT * FROM Familles WHERE RefFamille = @Ref";
            Cmd.Parameters.AddWithValue("@Ref", RefFamille);
            using (SQLiteDataReader reader = Cmd.ExecuteReader())
            {
                Famille famille = null;
                while (reader.Read())
                {
                    famille = new Famille();
                    famille.RefFamille = reader.GetInt32(0);
                    famille.Nom = reader.GetString(1);

                }
                return famille;
            }
        }

        /// <summary>
        /// Retourne le nombre d'articles dans la BDD
        /// </summary>
        /// <returns></returns>
        public static int GetNbArticles()
        {
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "SELECT COUNT(*) FROM Articles";
            using (SQLiteDataReader reader = Cmd.ExecuteReader())
            {
                int Nb = 0;
                while (reader.Read())
                {
                    Nb = reader.GetInt32(0);

                }
                return Nb;
            }
        }

        /// <summary>
        /// Récupère une Marque par sa référence
        /// </summary>
        /// <param name="RefMarque"></param>
        /// <returns></returns>
        public static Marque GetMarqueByRef(int RefMarque)
        {
            SQLiteCommand Cmd = new SQLiteCommand(DBConnection.Instance);
            Cmd.CommandText = "SELECT * FROM Marques WHERE RefMarque = @Ref";
            Cmd.Parameters.AddWithValue("@Ref", RefMarque);
            using (SQLiteDataReader reader = Cmd.ExecuteReader())
            {
                Marque Marque = null;
                while (reader.Read())
                {
                    Marque = new Marque();
                    Marque.RefMarque = reader.GetInt32(0);
                    Marque.Nom = reader.GetString(1);

                }
                return Marque;
            }
        }
        /// <summary>
        /// Récupère une SousFamille par sa référence
        /// </summary>
        /// <param name="refSousFamille"></param>
        /// <returns></returns>
        public static SousFamille GetSousFamilleByRef(int refSousFamille) //TODO : TEST
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM SousFamilles WHERE RefSousFamille = @ref";
            cmd.Parameters.AddWithValue("@ref", refSousFamille);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                SousFamille sousfamille = null;
                while (reader.Read())
                {
                    Famille famille = DBManager.GetFamilleByRef(reader.GetInt32(1));
                    sousfamille = new SousFamille();
                    sousfamille.RefSousFamille = reader.GetInt32(0);
                    sousfamille.Famille = famille;
                    sousfamille.Nom = reader.GetString(2);

                }
                return sousfamille;
            }
        }
        /// <summary>
        /// Récupère une Famille par son nom
        /// </summary>
        /// <param name="nomFamille"></param>
        /// <returns></returns>
        public static Famille GetFamilleByName(string nomFamille)
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Familles WHERE Nom = @Nom";
            cmd.Parameters.AddWithValue("@Nom", nomFamille);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                Famille famille = null;
                while (reader.Read())
                {
                     famille = new Famille();
                    famille.RefFamille = reader.GetInt32(0);
                    famille.Nom = reader.GetString(1);
                    
                }
                return famille;
            }
        }
        /// <summary>
        /// récupère une SousFamille par son nom
        /// </summary>
        /// <param name="nomSousFamille"></param>
        /// <returns></returns>
        public static SousFamille GetSousFamilleByName(string nomSousFamille) //TODO : TEST
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM SousFamilles WHERE Nom = @Nom";
            cmd.Parameters.AddWithValue("@Nom", nomSousFamille);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                SousFamille sousfamille = null;
                while (reader.Read())
                {
                    Famille famille = DBManager.GetFamilleByRef(reader.GetInt32(1));


                        sousfamille = new SousFamille();
               
                    sousfamille.RefSousFamille = reader.GetInt32(0);
                    sousfamille.Famille = famille;
                    sousfamille.Nom = reader.GetString(2);

                }
                return sousfamille;
            }
        }
        /// <summary>
        /// récupère une marque par son nom
        /// </summary>
        /// <param name="nomMarque"></param>
        /// <returns></returns>
        public static Marque GetMarqueByName(string nomMarque)
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Marques WHERE Nom = @Nom";
            cmd.Parameters.AddWithValue("@Nom", nomMarque);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                Marque marque = null;
                while (reader.Read())
                {
                    marque = new Marque();
                    marque.RefMarque = reader.GetInt32(0);
                    marque.Nom = reader.GetString(1);

                }
                return marque;
            }
        }
        /// <summary>
        /// récupère toutes les familles présentes dans la BDD
        /// </summary>
        /// <returns></returns>
        public static List<Famille> GetAllFamilles()
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Familles";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                List<Famille> Familles = new List<Famille>();
                while (reader.Read())
                {
                    Famille Famille = new Famille();
                    Famille.RefFamille = reader.GetInt32(0);
                    Famille.Nom = reader.GetString(1);
                    Familles.Add(Famille);

                }
                return Familles;
            }

        }
        /// <summary>
        /// Récupère toutes les marques présentes dans la BDD
        /// </summary>
        /// <returns></returns>
        public static List<Marque> GetAllMarques()
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Marques";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                List<Marque> Marques = new List<Marque>();
                while (reader.Read())
                {
                    Marque Marque = new Marque();
                    Marque.RefMarque = reader.GetInt32(0);
                    Marque.Nom = reader.GetString(1);
                    Marques.Add(Marque);

                }
                return Marques;
            }

        }
        /// <summary>
        /// récupère toutes les SousFamilles présentes dans la BDD
        /// </summary>
        /// <returns></returns>
        public static List<SousFamille> GetAllSousFamilles()
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM SousFamilles SF JOIN Familles F ON SF.RefFamille=F.RefFamille";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                List<SousFamille> SousFamilles = new List<SousFamille>();
                Famille Famille = null;
                while (reader.Read())
                {
                    Famille = new Famille();
                    SousFamille SousFamille = new SousFamille();
                    SousFamille.RefSousFamille = reader.GetInt32(0);
                    Famille.RefFamille = reader.GetInt32(1);
                    SousFamille.Nom= reader.GetString(2);
                    Famille.Nom = reader.GetString(4);
                    SousFamille.Famille = Famille;
                    SousFamilles.Add(SousFamille);

                }
                return SousFamilles;
            }

        }
        /// <summary>
        /// récupère tous les Articles présents dans la BDD
        /// </summary>
        /// <returns></returns>
        public static List<Article> GetAllArticles()
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Articles A NATURAL JOIN Marques M JOIN SousFamilles SF ON A.RefSousFamille= SF.RefSousFamille  JOIN Familles F ON SF.RefFamille = F.RefFamille;";
            List<Article> articles = new List<Article>();
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                Marque marque = null;
                Famille famille = null;
                SousFamille sousFamille = null;
                Article article = null;

                
                while (reader.Read())
                {
                    marque = new Marque();
                    famille = new Famille();
                    sousFamille = new SousFamille();
                    article = new Article();
                    article.RefArticle = reader.GetString(0);
                    article.Description = reader.GetString(1);
                    sousFamille.RefSousFamille = reader.GetInt32(2);
                    marque.RefMarque = reader.GetInt32(3);
                    article.PrixHT = reader.GetFloat(4);
                    article.Quantite = reader.GetInt32(5);
                    marque.Nom = reader.GetString(6);
                    famille.RefFamille = reader.GetInt32(8);
                    sousFamille.Nom = reader.GetString(9);
                    famille.Nom = reader.GetString(11);
                    sousFamille.Famille = famille;
                    article.SousFamille = sousFamille;
                    article.Marque = marque;
                    articles.Add(article);


                }
                return articles;
            }
        }
        /// <summary>
        /// récupère un Article présents dans la BDD par sa référence
        /// </summary>
        /// <returns></returns>
        public static Article GetArticleByRef(String RefArticle)
        {
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT * FROM Articles A NATURAL JOIN Marques M JOIN SousFamilles SF ON A.RefSousFamille= SF.RefSousFamille  JOIN Familles F ON SF.RefFamille = F.RefFamille  WHERE RefArticle = @Ref;";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref", RefArticle);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                Marque marque = null;
                Famille famille = null;
                SousFamille sousFamille = null;
                Article article = null;


                while (reader.Read())
                {
                    marque = new Marque();
                    famille = new Famille();
                    sousFamille = new SousFamille();
                    article = new Article();
                    article.RefArticle = reader.GetString(0);
                    article.Description = reader.GetString(1);
                    sousFamille.RefSousFamille = reader.GetInt32(2);
                    marque.RefMarque = reader.GetInt32(3);
                    String prix = reader.GetFloat(4).ToString();
                    prix.Replace(",", ".");
                    article.PrixHT = reader.GetFloat(4)/*float.Parse(prix, CultureInfo.InvariantCulture.NumberFormat)*/;
                    marque.Nom = reader.GetString(6);
                    famille.RefFamille = reader.GetInt32(8);
                    sousFamille.Nom = reader.GetString(9);
                    famille.Nom = reader.GetString(11);
                    sousFamille.Famille = famille;
                    article.SousFamille = sousFamille;
                    article.Marque = marque;


                }
                return article;
            }
        }
        /// <summary>
        /// Ajoute un Article à la BDD
        /// </summary>
        /// <param name="Article"></param>
        /// <returns></returns>
        public static bool InsertArticle(Article Article)
        {
            bool inserted = true;
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "INSERT INTO Articles(RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES(@Ref,@Desc,@RefSousFamille,@RefMarque,@Prix,@Qt); ";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref", Article.RefArticle);
            cmd.Parameters.AddWithValue("@Desc", Article.Description);
            cmd.Parameters.AddWithValue("@RefSousFamille", Article.SousFamille.RefSousFamille);
            cmd.Parameters.AddWithValue("@RefMarque", Article.Marque.RefMarque);
            cmd.Parameters.AddWithValue("@Prix", Article.PrixHT);
            cmd.Parameters.AddWithValue("@Qt", Article.Quantite);
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                inserted = false;
            }
            return inserted;
        }
        /// <summary>
        /// Modifie un Article dans la BDD
        /// </summary>
        /// <param name="Article"></param>
        /// <returns></returns>
        public static bool UpdateArticle(Article Article)
        {
            bool updated = true;
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "UPDATE Articles SET Description = @Desc, RefSousFamille = @RefSousFamille, RefMarque = @RefMarque, PrixHT = @Prix, Quantite = @Qt WHERE RefArticle=@Ref; ";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref", Article.RefArticle);
            cmd.Parameters.AddWithValue("@Desc", Article.Description);
            cmd.Parameters.AddWithValue("@RefSousFamille", Article.SousFamille.RefSousFamille);
            cmd.Parameters.AddWithValue("@RefMarque", Article.Marque.RefMarque);
            cmd.Parameters.AddWithValue("@Prix", Article.PrixHT);
            cmd.Parameters.AddWithValue("@Qt", Article.Quantite);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                updated = false;
            }
            return updated;
        }
        /// <summary>
        /// Supprime un article de la BDD
        /// </summary>
        /// <param name="RefArticle"></param>
        /// <returns></returns>
        public static int DeleteArticleByRef(String RefArticle)
        {
            int deleted = 0;
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "DELETE FROM Articles WHERE RefArticle = @Ref";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref", RefArticle);
            try
            {
                deleted = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return deleted;
        }
        /// <summary>
        /// Met à jour les réfèrences de chaque table afin de pouvoir incrémenter correctement lors de l'ajout d'un objet dans la table
        /// </summary>
        public static void MajRef()
        {
            int nextID;
            SQLiteCommand cmd = new SQLiteCommand(DBConnection.Instance);
            cmd.CommandText = "SELECT  MAX(RefFamille) AS nextID  FROM Familles";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["nextID"].ToString() != "")
                    {
                        nextID = Int32.Parse(reader["nextID"].ToString());
                        NextRefFamille = ++nextID;
                    }
                    else
                    {
                        NextRefFamille = 1;
                    }
                }
            }
            cmd.CommandText = "SELECT  MAX(RefMarque) AS nextID  FROM Marques";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["nextID"].ToString() != "")
                    {
                        nextID = Int32.Parse(reader["nextID"].ToString());
                        NextRefMarque = ++nextID;
                    }
                    else
                    {
                        NextRefMarque = 1;
                    }
                }
            }
            cmd.CommandText = "SELECT  MAX(RefSousFamille) AS nextID  FROM SousFamilles";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["nextID"].ToString() != "")
                    {
                        nextID = Int32.Parse(reader["nextID"].ToString());
                        NextRefSousFamille = ++nextID;
                    }
                    else
                    {
                        NextRefSousFamille = 1;
                    }
                }
            }


        }
    } 
        
}

