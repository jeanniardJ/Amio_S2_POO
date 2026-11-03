namespace S2_POO_TP_PANIER_DLL
{
    public class Article(int reference, string designation, double prix) : IComparable<Article>
    {
        private readonly int Reference = reference;

        private readonly string Designation = designation;

        public double Prix { get; } = prix;

        /// <summary>
        /// Returns a formatted description of the article.
        /// </summary>
        /// <returns>
        /// A string containing the article price, reference, and designation.
        /// </returns>
        public override string ToString()
        {
            return $"Prix de l'article : {Prix}, référence : {Reference} et désignation : {Designation}";
        }

        /// <summary>
        /// Compares the current article with another object.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>
        /// <c>true</c> if the object is an article with the same reference;
        /// otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Compares the current article with another article and returns a value that indicates their relative order
        /// based on the Reference property.
        /// </summary>
        /// <param name="other">The article to compare with the current instance.</param>
        /// <returns>A value less than zero if this instance precedes other, zero if they are equal, or greater than zero if this
        /// instance follows other.</returns>
        public int CompareTo(Article? other)
        {
            if (other == null) return 1;

            return Reference.CompareTo(other.Reference);
        }

        /// <summary>
        /// Returns a hash code based on the article reference.
        /// </summary>
        /// <returns>
        /// A hash code generated from the article reference.
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
