using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe Famille.
    /// </summary>
    public class Famille
    {
        private int refFamille;
        private string nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Famille()
        {
        }

        /// <summary>
        /// Référence de la famille.
        /// </summary>
        public int RefFamille { get => refFamille; set => refFamille = value; }

        /// <summary>
        /// Nom de la famille.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
    }
}
