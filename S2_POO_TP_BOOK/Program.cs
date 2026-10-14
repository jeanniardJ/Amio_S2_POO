namespace S2_POO_TP_BOOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livre> livres = new List<Livre> {
                new Livre("Le Petit Prince", "Saint-Exupéry", "Antoine", 12.90f),
                new Livre("L'Étranger", "Camus", "Albert", 9.50f),
                new Livre("1984", "Orwell", "George", 14.20f),
                new Livre("Le Comte de Monte-Cristo", "Dumas", "Alexandre", 18.75f),
                new Livre("Mademoiselle de La Roque", "Duhamel", "Marcel", 11.30f)};

            foreach (var item in livres)
            {
                item.Afficher();
            }
        }
    }
}
