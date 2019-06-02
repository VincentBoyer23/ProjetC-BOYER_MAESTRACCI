using System.Data.SQLite;

namespace Bacchus
{
    public sealed class DBConnection
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static volatile SQLiteConnection instance = null;
        /// <summary>
        /// The synchronize root
        /// </summary>
        private static object Sync_Root = new object();
        /// <summary>
        /// The connection string
        /// </summary>
        private const string Connection_String = "Data Source=Bacchus.SQLite;Version=3;";


        /// <summary>
        /// Prevents a default instance of the <see cref="DBConnection" /> class from being created.
        /// </summary>
        private DBConnection()
        {
        }

        /// <summary>
        /// Ferme l'instance <see cref="DBConnection" /> class.
        /// </summary>
        ~DBConnection()
        {
            instance.Close();
        }

        /// <summary>
        /// Récupère l'instance.
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
                            DBManager.MajRef();
                        }
                    }
                }

                return instance;
            }
        }
    }
    }
