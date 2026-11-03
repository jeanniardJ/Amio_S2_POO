namespace S2_POO_TP_PANIER_DLL
{
    internal class Panier
    {
        private static int CptPanier;

        private readonly DateTime DateCreation = new DateTime();

        private int NumeroPanier = ++CptPanier;

        private List<LignePanier> Lignes = new List<LignePanier>();

        public void AjouterArticle (Article article, int quantite)
        {
            //verifier que l'article existe pas déja dans la collection
            Lignes.Add(new LignePanier(article, quantite));
        }

        public void AjouteArticle(Article article)
        {
            //verifier que l'article existe pas déja dans la collection
            Lignes.Add(new LignePanier(article, 1));
        }

        public void Afficher()
        {

        }

        public double Total()
        {
            return 0.0;
        }

        public void Vider()
        {

        }

        public void SupprimerArticle(Article article)
        {

        }
    }
}
