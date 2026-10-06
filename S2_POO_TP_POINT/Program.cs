namespace S2_POO_TP_POINT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(2,6);

            pointA.Norme(6, 8);

            Console.WriteLine($"Donner l'anscisse : {pointA.Abscisse}");
            Console.WriteLine($"Donner l'ordonne : {pointA.Ordonnee}");
            Console.WriteLine($"La norme du point (6,8) est : {pointA.Norme(6, 8)}");
        }
    }
}
