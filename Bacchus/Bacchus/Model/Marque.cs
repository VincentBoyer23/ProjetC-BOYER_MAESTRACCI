using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Marque
    {
        private int refMarque;
        private string nom;

        public Marque()
        {
        }

        public int RefMarque { get => refMarque; set => refMarque = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
