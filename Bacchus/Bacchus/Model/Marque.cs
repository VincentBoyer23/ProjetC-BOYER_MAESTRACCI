using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe Marque.
    /// </summary>
    public class Marque
    {
        private int refMarque;
        private string nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Marque()
        {
        }

        /// <summary>
        /// Référence de la marque.
        /// </summary>
        public int RefMarque { get => refMarque; set => refMarque = value; }

        /// <summary>
        /// Nom de la marque.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
    }
}
