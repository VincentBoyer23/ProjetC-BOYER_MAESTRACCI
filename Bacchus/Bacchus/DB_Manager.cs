using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;

namespace Bacchus
{
    /// <summary>
    /// Class DB_Manager. This class cannot be inherited.
    /// </summary>
    public sealed class DB_Manager
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static  volatile SQLiteConnection instance= null;
        /// <summary>
        /// The synchronize root
        /// </summary>
        private static object Sync_Root = new object();
        /// <summary>
        /// The connection string
        /// </summary>
        private const string Connection_String = "Data Source=Bacchus.SQLite;Version=3;";
        /// <summary>
        /// The identifier marque
        /// </summary>
        private static int Id_Marque =1;
        /// <summary>
        /// The identifier famille
        /// </summary>
        private static int Id_Famille= 1;
        /// <summary>
        /// The identifier sous famille
        /// </summary>
        private static int Id_Sous_Famille=1;


        /// <summary>
        /// Prevents a default instance of the <see cref="DB_Manager" /> class from being created.
        /// </summary>
        private DB_Manager()
        {
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="DB_Manager" /> class.
        /// </summary>
        ~DB_Manager()
        {
            instance.Close();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static SQLiteConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Sync_Root)
                    {
                        if (instance == null)
                        {
                            instance = new SQLiteConnection(Connection_String);
                            instance.Open();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Deletes the article.
        /// </summary>
        /// <param name="Ref_Article">The reference article.</param>
        /// <returns>System.Int32.</returns>
        public static int Delete_Article(string Ref_Article)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "DELETE  FROM Articles WHERE RefArticle='" + Ref_Article + "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour = cmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Deletes the famille.
        /// </summary>
        /// <param name="Ref">The reference.</param>
        /// <returns>System.Int32.</returns>
        public static int Delete_Famille(int Ref)
        {
            int Retour = -1;
            try
            {
                SQLiteDataReader Reader = Get_All_Sous_Famille(Ref);
                Retour = 0;
                while (Reader.Read())
                {
                    Retour += Delete_Sous_Famille(Int32.Parse(Reader["RefSousFamille"].ToString()));
                }

                string SQL_Text = "DELETE  FROM Familles WHERE RefFamille='" + Ref + "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Deletes the sous famille.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public static int Purge_Database()
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "TRUNCATE TABLE SousFamilles;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour = cmd.ExecuteNonQuery();
                SQL_Text = "DELETE FROM Familles;";
                cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();
                SQL_Text = "DELETE FROM Marques;";
                cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();
                SQL_Text = "DELETE FROM Articles;";
                cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();


            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Deletes the sous famille.
        /// </summary>
        /// <param name="Ref">The reference.</param>
        /// <returns>System.Int32.</returns>
        public static int Delete_Sous_Famille(int Ref)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "DELETE  FROM Articles WHERE RefSousFamille='" + Ref + "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour = cmd.ExecuteNonQuery();
                SQL_Text = "DELETE  FROM SousFamilles WHERE RefSousFamille='" + Ref + "';";
                cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();


            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }
        /// <summary>
        /// Gets the reference famille.
        /// </summary>
        /// <param name="Famille">The famille.</param>
        /// <returns>System.Int32.</returns>
        public static int Get_Ref_Famille(string Famille)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "SELECT RefFamille FROM Familles WHERE Nom='" + Famille+"';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Retour = Int32.Parse(reader["RefFamille"].ToString());
                    }
                }

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Gets the name famille.
        /// </summary>
        /// <param name="Ref">The reference.</param>
        /// <returns>System.String.</returns>
        public static string Get_Name_Famille(int Ref)
        {
            string Retour = null;
            try
            {
                string SQL_Text = "SELECT Nom FROM Familles WHERE RefFamille='" + Ref + "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Retour = reader["Nom"].ToString();
                    }
                }

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Inserts the new famille.
        /// </summary>
        /// <param name="Famille">The famille.</param>
        /// <returns>System.Int32.</returns>
        public static  int Insert_new_Famille(string Famille)
        {
            int Retour = -1;
            
                SQLiteCommand cmd = new SQLiteCommand(Instance);
                cmd.CommandText = "INSERT INTO Familles(RefFamille,Nom) VALUES (@Ref, @Famille)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ref", Id_Famille);
                cmd.Parameters.AddWithValue("@Famille", Famille);
                Id_Famille++;
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Updates the famille.
        /// </summary>
        /// <param name="refFamille">The reference famille.</param>
        /// <param name="Famille">The famille.</param>
        /// <returns>System.Int32.</returns>
        public static int Update_Famille(int refFamille, string Famille)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "UPDATE Familles "
                + "SET Nom = @Famille "
                + "WHERE RefFamille = @Ref";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Famille", Famille);
            cmd.Parameters.AddWithValue("@Ref", refFamille);
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Inserts the new article.
        /// </summary>
        /// <param name="Ref_Article">The reference article.</param>
        /// <param name="Desc">The desc.</param>
        /// <param name="Ref_Sous_Famille">The reference sous famille.</param>
        /// <param name="Ref_Marque">The reference marque.</param>
        /// <param name="Prix">The prix.</param>
        /// <param name="Qt">The qt.</param>
        /// <returns>System.Int32.</returns>
        public static int Insert_New_Article(string Ref_Article, string Desc, int Ref_Sous_Famille, int Ref_Marque, float Prix, int Qt)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "INSERT INTO Articles(RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (@Ref_Article, @Desc, @Ref_Sous_Famille, @Ref_Marque, @Prix, @Qt)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Ref_Sous_Famille", Ref_Sous_Famille);
            cmd.Parameters.AddWithValue("@Ref_Marque", Ref_Marque);
            cmd.Parameters.AddWithValue("@Prix", Prix);
            cmd.Parameters.AddWithValue("@Qt", Qt);
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Updates the article.
        /// </summary>
        /// <param name="Old_Ref">The old reference.</param>
        /// <param name="Ref_Article">The reference article.</param>
        /// <param name="Desc">The desc.</param>
        /// <param name="Ref_Sous_Famille">The reference sous famille.</param>
        /// <param name="Ref_Marque">The reference marque.</param>
        /// <param name="Prix">The prix.</param>
        /// <param name="Qt">The qt.</param>
        /// <returns>System.Int32.</returns>
        public static int Update_Article(string Old_Ref, string Ref_Article, string Desc, int Ref_Sous_Famille, int Ref_Marque, float Prix, int Qt)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "UPDATE Articles SET RefArticle = @Ref_Article, Description =@Desc , RefSousFamille =  @Ref_Sous_Famille, RefMarque = @Ref_Marque, PrixHT = @Prix, Quantite =  @Qt WHERE RefArticle = @Old";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Old", Old_Ref);
            cmd.Parameters.AddWithValue("@Ref_Article", Ref_Article);
            cmd.Parameters.AddWithValue("@Desc", Desc);
            cmd.Parameters.AddWithValue("@Ref_Sous_Famille", Ref_Sous_Famille);
            cmd.Parameters.AddWithValue("@Ref_Marque", Ref_Marque);
            cmd.Parameters.AddWithValue("@Prix", Prix);
            cmd.Parameters.AddWithValue("@Qt", Qt);
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }




        /// <summary>
        /// Gets the reference marque.
        /// </summary>
        /// <param name="Marque">The marque.</param>
        /// <returns>System.Int32.</returns>
     public static  int Get_Ref_Marque(string Marque)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "SELECT RefMarque FROM Marques WHERE Nom='" + Marque+"';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Retour = Int32.Parse(reader["RefMarque"].ToString());
                    }
                }

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

     /// <summary>
     /// Inserts the new marque.
     /// </summary>
     /// <param name="Marque">The marque.</param>
     /// <returns>System.Int32.</returns>
        public static  int Insert_new_Marque(string Marque)
        {
            int Retour = -1;
            
                SQLiteCommand cmd = new SQLiteCommand(Instance);
                cmd.CommandText = "INSERT INTO Marques(RefMarque, Nom) VALUES (@Ref, @Marque)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Ref", Id_Marque);
                cmd.Parameters.AddWithValue("@Marque", Marque);
                Id_Marque++;
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Deletes the marque.
        /// </summary>
        /// <param name="Ref_Marque">The reference marque.</param>
        /// <returns>System.Int32.</returns>
        public static int Delete_Marque(int Ref_Marque)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "DELETE  FROM Articles WHERE RefMarque='" + Ref_Marque+ "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour = cmd.ExecuteNonQuery();
                SQL_Text = "DELETE  FROM Marques WHERE RefMarque='" + Ref_Marque + "';";
                cmd = new SQLiteCommand(SQL_Text, Instance);
                Retour += cmd.ExecuteNonQuery();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Updates the marque.
        /// </summary>
        /// <param name="Old_Ref">The old reference.</param>
        /// <param name="Ref_Marque">The reference marque.</param>
        /// <param name="Marque">The marque.</param>
        /// <returns>System.Int32.</returns>
        public static int Update_Marque(int Old_Ref,int Ref_Marque, string Marque)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "UPDATE Marques "
                + "SET RefMarque = @Ref,Nom = @Marque "
                + "WHERE RefMarque = @Old";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Old", Old_Ref);
            cmd.Parameters.AddWithValue("@Marque", Marque);
            cmd.Parameters.AddWithValue("@Ref", Ref_Marque);
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Gets all marques.
        /// </summary>
        /// <returns>SQLiteDataReader.</returns>
        public static SQLiteDataReader Get_All_Marques()
        {
            SQLiteDataReader reader = null;
            try
            {
                string SQL_Text = "SELECT * FROM Marques;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// Gets all familles.
        /// </summary>
        /// <returns>SQLiteDataReader.</returns>
        public static SQLiteDataReader Get_All_Familles()
        {
            SQLiteDataReader reader = null;
            try
            {
                string SQL_Text = "SELECT * FROM Familles;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// Gets all sous famille.
        /// </summary>
        /// <param name="Ref_Famille">The reference famille.</param>
        /// <returns>SQLiteDataReader.</returns>
        public static SQLiteDataReader Get_All_Sous_Famille(int Ref_Famille)
        {
            SQLiteDataReader reader = null;
            try
            {
                string SQL_Text = "SELECT * FROM SousFamilles WHERE RefFamille= '" + Ref_Famille + "';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// Gets all sous famille.
        /// </summary>
        /// <returns>SQLiteDataReader.</returns>
        public static SQLiteDataReader Get_All_Sous_Famille()
        {
            SQLiteDataReader reader = null;
            try
            {
                string SQL_Text = "SELECT * FROM SousFamilles;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// Gets all articles.
        /// </summary>
        public static void Get_All_Articles()
        {
            try
            {
                string SQL_Text = "SELECT * FROM Articles;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Ref Article: " + reader["RefArticle"].ToString() + " , Description: " + reader["Description"].ToString() + " , RefSousFamille: " + reader["RefSousFamille"].ToString() + " , RefMarque: " + reader["RefMarque"].ToString() + " , PrixHT: " + (float.Parse(reader["PrixHT"].ToString())).ToString("n2") + " , Quantite: " + reader["Quantite"].ToString()); 
                    }
                }

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Gets all articles details.
        /// </summary>
        /// <returns>SQLiteDataReader.</returns>
        public static SQLiteDataReader Get_All_Articles_Details()
        {
            SQLiteDataReader reader =null;
            try
            {
                string SQL_Text = "SELECT A.RefArticle, A.Description, A.PrixHT, A.Quantite, M.Nom as Marque, F.Nom as Famille, SF.Nom as SousFamille FROM Articles A JOIN Marques M ON A.RefMarque = M.RefMarque JOIN SousFamilles SF ON A.RefSousFamille = SF.RefSousFamille JOIN Familles F ON SF.RefFamille = F.RefFamille;";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                reader = cmd.ExecuteReader();

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;

        }
        /// <summary>
        /// Gets the reference sous famille.
        /// </summary>
        /// <param name="ref_Famille">The reference famille.</param>
        /// <param name="Sous_Famille">The sous famille.</param>
        /// <returns>System.Int32.</returns>
        public static int Get_Ref_Sous_Famille(int ref_Famille, string Sous_Famille)
        {
            int Retour = -1;
            try
            {
                string SQL_Text = "SELECT RefSousFamille FROM SousFamilles WHERE Nom= '" + Sous_Famille + "' AND RefFamille= '"+ref_Famille+"';";
                SQLiteCommand cmd = new SQLiteCommand(SQL_Text, Instance);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Retour = Int32.Parse(reader["RefSousFamille"].ToString());
                    }
                }

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Inserts the new sous famille.
        /// </summary>
        /// <param name="Ref_Famille">The reference famille.</param>
        /// <param name="Sous_Famille">The sous famille.</param>
        /// <returns>System.Int32.</returns>
        public static int Insert_new_Sous_Famille(int Ref_Famille, string Sous_Famille)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "INSERT INTO SousFamilles(RefSousFamille, RefFamille, Nom) VALUES (@Ref, @RefFamille, @Sous_Famille)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Ref", Id_Sous_Famille);
            cmd.Parameters.AddWithValue("@RefFamille", Ref_Famille);
            cmd.Parameters.AddWithValue("@Sous_Famille", Sous_Famille);
            Id_Sous_Famille++;
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }

        /// <summary>
        /// Updates the sous famille.
        /// </summary>
        /// <param name="Ref_Sous_Famille">The reference sous famille.</param>
        /// <param name="Ref_Famille">The reference famille.</param>
        /// <param name="Sous_Famille">The sous famille.</param>
        /// <returns>System.Int32.</returns>
        public static int Update_Sous_Famille(int Ref_Sous_Famille,int Ref_Famille, string Sous_Famille)
        {
            int Retour = -1;

            SQLiteCommand cmd = new SQLiteCommand(Instance);
            cmd.CommandText = "UPDATE SousFamilles "
                + "SET Nom = @Sous_Famille, "
                + " RefFamille = @Ref_Famille "
                + "WHERE RefSousFamille = @Ref";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Sous_Famille", Sous_Famille);
            cmd.Parameters.AddWithValue("@Ref_Famille", Ref_Famille);
            cmd.Parameters.AddWithValue("@Ref", Ref_Sous_Famille);
            try
            {
                Retour = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return Retour;
        }
      }
    }


