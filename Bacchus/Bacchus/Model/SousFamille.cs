using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe Sous Famille.
    /// </summary>
    public class SousFamille
    {
        private int refSousFamille;
        private Famille famille;
        private string nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        public SousFamille()
        {
        }

        /// <summary>
        /// Reférence de la sous famille.
        /// </summary>
        public int RefSousFamille { get => refSousFamille; set => refSousFamille = value; }

        /// <summary>
        /// Nom de la sous famille.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        internal Famille Famille { get => famille; set => famille = value; }
    }
}
