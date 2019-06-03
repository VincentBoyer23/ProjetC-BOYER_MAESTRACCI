using System;
using System.Collections.Generic;

namespace Bacchus.Model
{
    /// <summary>
    /// Classe Article
    /// </summary>
    public class Article
    {
       private string refArticle;
       private string description;
       private SousFamille sousFamille;
       private Marque marque;
       private float prixHT;
       private int quantite;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Article()
        {
        }

        /// <summary>
        /// Référence de l'article
        /// </summary>
        public string RefArticle { get => refArticle; set => refArticle = value; }

        /// <summary>
        /// Description de l'article
        /// </summary>
        public string Description { get => description; set => description = value; }

        /// <summary>
        /// Prix de l'article Hors Taxe
        /// </summary>
        public float PrixHT { get => prixHT; set => prixHT = value; }

        /// <summary>
        /// Quantite de l'article
        /// </summary>
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// Sous Famille de l'article.
        /// </summary>
        internal SousFamille SousFamille { get => sousFamille; set => sousFamille = value; }

        /// <summary>
        /// Marque de l'article.
        /// </summary>
        internal Marque Marque { get => marque; set => marque = value; }

        /// <summary>
        /// Renvoie l'article sous forme d'une ligne CSV.
        /// </summary>
        /// <returns>l'article sous forme d'une ligne CSV.</returns>
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
