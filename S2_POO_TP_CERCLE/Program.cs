namespace S2_POO_TP_CERCLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abscCercle;
            int ordonCercle;
            int rayonCercle;
            int absPoint;
            int ordonPoint;

            Console.Write("Donner l'abscisse du centre: ");
            int.TryParse(Console.ReadLine(), out abscCercle);
            Console.Write("Donner l'ordonné du centre: ");
            int.TryParse(Console.ReadLine(), out ordonCercle);
            Console.Write("Donner le rayon: ");
            int.TryParse(Console.ReadLine(), out rayonCercle);

            Cercle cercleA = new(abscCercle, ordonCercle, rayonCercle);

            cercleA.Affiche();
            cercleA.GetPerimetre();
            cercleA.GetSurface();

            Console.Write("Donner un point :");
            Console.Write("\nx: ");
            int.TryParse(Console.ReadLine(), out absPoint);
            Console.Write("y: ");
            int.TryParse(Console.ReadLine(), out ordonPoint);

            Point ptA = new(absPoint,ordonPoint);

            ptA.Afficher();

            //Console.WriteLine(cercleA.Appartient(ptA));

            Console.WriteLine($"Le point {(cercleA.Appartient(ptA) ? "appartient" : "n'appartient pas")} au cercle.");
        }
    }
}
