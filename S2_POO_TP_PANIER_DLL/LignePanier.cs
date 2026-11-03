namespace S2_POO_TP_PANIER_DLL
{
    public class LignePanier(Article article, int quantite)
    {
        public Article Article { get; }  = article;

        public int Quantite { get; set; } = quantite;

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
