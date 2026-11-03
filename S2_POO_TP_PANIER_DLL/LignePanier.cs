namespace S2_POO_TP_PANIER_DLL
{
    internal class LignePanier(Article article, int quantite)
    {
        private readonly Article Article = article;

        private readonly int Quantite = quantite;

        public override string ToString()
        {
            return $"{Article}, quantité : {Quantite} et le montant est {Montant()}";
        }

        public double Montant()
        {
            return Quantite * Article.Prix;
        }
    }
}
