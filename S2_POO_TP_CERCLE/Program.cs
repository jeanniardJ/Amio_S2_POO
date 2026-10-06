namespace S2_POO_TP_CERCLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner l'abscisse du centre:");
            int absc = Console.Read();
            Console.WriteLine("Donner l'ordonné du centre:");
            int ordon = Console.Read();
            Console.WriteLine("Donner le rayon:");
            int rayon = Console.Read();

            Cercle cercleA = new(5, 4, 6);

            Point ptA = new(2,6);

            ptA.Afficher();
        }
    }
}
