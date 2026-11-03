namespace S2_POO_TP_PANIER_DLL
{
    public class Panier
    {
        private static int CptPanier;

        private readonly DateTime DateCreation = new DateTime();

        private readonly int NumeroPanier = ++CptPanier;

        private List<LignePanier> Lignes = new List<LignePanier>();

        public void AjouterArticle (Article article, int quantite)
        {
            LignePanier? ligne = Lignes.Find(ligne => ligne.Article.Equals(article));

            //verifier que l'article existe pas déja dans la collection
            if (ligne != null)
            {
                ligne.Quantite += quantite;
            }
            else
            {
                Lignes.Add(new LignePanier(article, quantite));
            }
                
        }

        public void AjouterArticle(Article article)
        {
            AjouterArticle(article, 1);
        }

        public void Afficher()
        {
            foreach (LignePanier articles in Lignes)
            {
                Console.WriteLine($"{articles}");
            }
        }

        public double Total()
        {
            double toto = 0;

            foreach (LignePanier item in Lignes)
            {
                toto += item.Montant();
            }

            return toto;
        }

        public void Vider()
        {
            Lignes.Clear();
        }

        public void SupprimerArticle(Article article)
        {
            LignePanier? ligne = Lignes.Find(ligne => ligne.Article.Equals(article));

            if(ligne != null)
            {
                Lignes.Remove(ligne);
            }
        }
    }
}
