using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class SousFamille
    {
        private int refSousFamille;
        private Famille famille;
        private string nom;

        public SousFamille()
        {
        }

        public int RefSousFamille { get => refSousFamille; set => refSousFamille = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Famille Famille { get => famille; set => famille = value; }
    }
}
