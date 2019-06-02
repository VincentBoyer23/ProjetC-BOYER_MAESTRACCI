using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Famille
    {
        private int refFamille;
        private string nom;

        public Famille()
        {
        }

        public int RefFamille { get => refFamille; set => refFamille = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
