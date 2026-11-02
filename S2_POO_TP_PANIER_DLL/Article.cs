namespace S2_POO_TP_PANIER_DLL
{
    public class Article : IComparable<Article>
    {
        private int Reference;

        private string Designation;

        private double Prix;

        public Article(int reference, string designation, double prix)
        {
            Reference = reference;
            Designation = designation;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"Prix de l'article : {Prix}, référence : {Reference} et désignation : {Designation}";
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Article article = (Article)obj;
                return (Reference == article.Reference);
            }
        }

        public int CompareTo(Article? other)
        {
            if (other == null) return 1;

            return Reference.CompareTo(other.Reference);
        }
    }
}
