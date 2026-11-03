using S2_POO_TP_PANIER_DLL;

namespace S2_POO_TP_PANIER_CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'articles
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(2, "Souris", 19.99);
            Article article3 = new(3, "Écran", 199.99);

            // Création du panier
            Panier panier = new();

            Console.WriteLine("=== AJOUT D'ARTICLES ===");

            panier.AjouterArticle(article1);
            panier.AjouterArticle(article2, 2);
            panier.AjouterArticle(article3, 1);

            panier.AjouterArticle(article1, 2); // Test cumul des quantités

            Console.WriteLine($"\nContenu du panier {panier.NumeroPanier}:");
            panier.Afficher();

            Console.WriteLine($"\nTotal : {panier.Total():C}");

            Console.WriteLine("\n=== SUPPRESSION D'UN ARTICLE ===");

            panier.SupprimerArticle(article2);

            panier.Afficher();

            Console.WriteLine($"\nTotal : {panier.Total():C}");

            Console.WriteLine("\n=== VIDAGE DU PANIER ===");

            panier.Vider();

            panier.Afficher();

            Console.WriteLine($"\nTotal : {panier.Total():C}");

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}