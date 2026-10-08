using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_ARTICLE
{
    public class Article
    {
        public string Reference { get; set; }

        public string Designation { get; set; }

        public decimal PrixHT { get; set; }

        public static int TauxTva;

        private static int cptInstance = 1;

        private int Index;

        public Article() {
            //A chaque instanciation je veux incrementation
            Index = cptInstance++;
        }

        public Article(Article article) {
            Reference = article.Reference;
            Designation = article.Designation;
            PrixHT = article.PrixHT;
        }

        public Article(string reference)
        {
            Reference = reference;
            Index = cptInstance++;
        }

        public Article(string reference, string designation)
        {
            Reference = reference;
            Designation = designation;
            Index = cptInstance++;
        }

        public Article(string reference, string designation, decimal prixht)
        {
            Reference = reference;
            Designation = designation;
            PrixHT = prixht;
            Index = cptInstance++;
        }

        public decimal CalculerPrixTTC()
        {
            return PrixHT * TauxTva / 100;
        }

        public void AfficherArticle()
        {
            string article = "";

            article += $"Article : {Index}";
            article += $"\nRéférence : {Reference}";
            article += $"\nDésignation : {Designation}";
            article += $"\nPrix HT: {PrixHT}";
            article += $"\nPrix TTC: {CalculerPrixTTC()}";
            Console.WriteLine(article + "\n");
        }
    }
}
