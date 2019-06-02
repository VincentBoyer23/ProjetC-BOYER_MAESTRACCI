using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Article
    {
       private string refArticle;
       private string description;
       private SousFamille sousFamille;
       private Marque marque;
       private float prixHT;
       private int quantite;

        public Article()
        {
        }

        public string RefArticle { get => refArticle; set => refArticle = value; }
        public string Description { get => description; set => description = value; }
        public float PrixHT { get => prixHT; set => prixHT = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        internal SousFamille SousFamille { get => sousFamille; set => sousFamille = value; }
        internal Marque Marque { get => marque; set => marque = value; }

        public String toCSV()
        {
            List<string> myStrings = new List<string>();
            myStrings.Add(this.Description);
            myStrings.Add(this.RefArticle);
            myStrings.Add(this.Marque.Nom);
            myStrings.Add(this.SousFamille.Famille.Nom);
            myStrings.Add(this.SousFamille.Nom);
            myStrings.Add(this.prixHT.ToString());

            return string.Join(";", myStrings);

        }
    }
}
