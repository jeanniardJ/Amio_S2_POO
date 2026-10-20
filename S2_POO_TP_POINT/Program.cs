namespace S2_POO_TP_POINT;

internal class Program
{
    static void Main(string[] args)
    {
        Point pointA = new Point(2,6);

        pointA.Norme();

        Console.WriteLine($"Donner l'anscisse : {pointA.Abscisse}");
        Console.WriteLine($"Donner l'ordonne : {pointA.Ordonne}");
        Console.WriteLine($"La norme du point est : {pointA.Norme()}");
    }
}
