namespace S2_POO_TP_ARTICLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article.TauxTva = 20;

            // Constructeur par défaut
            Article a1 = new Article();
            a1.Reference = "ART-001";
            a1.Designation = "Clavier mécanique";
            a1.PrixHT = 89.90m;

            // Constructeur tous attributs
            Article a2 = new Article("ART-002", "Souris sans fil", 34.50m);
            Article a3 = new Article("ART-003", "Écran 27 pouces", 249.00m);
            Article a4 = new Article("ART-004", "Casque audio", 129.99m);
            Article a5 = new Article("ART-005", "Webcam HD", 59.90m);
            Article a6 = new Article("ART-006", "Support laptop", 45.00m);
            Article a7 = new Article("ART-007", "Câble HDMI 2m", 12.99m);
            Article a8 = new Article("ART-008", "Tapis de souris", 15.50m);

            // Constructeur référence + désignation
            Article a9 = new Article("ART-009", "Station d'accueil");
            a9.PrixHT = 199.00m;

            // Constructeur de recopie
            Article a10 = new Article(a2);

            a1.AfficherArticle();
            a2.AfficherArticle();
                        
            a5.AfficherArticle();


            Console.WriteLine($"Le prix TTC est {a1.CalculerPrixTTC()} sur l'article {a1.Reference}");
        }
    }
}
