namespace S2_POO_TP_CERCLE;

internal class Point
{
    public double Abscisse { get; private set; }
    public double Ordonnee { get; }

    public Point(double x, double y)
    {
        Abscisse = x;
        Ordonnee = y;
    }

    public void Afficher()
    {
        Console.WriteLine($"POINT({Abscisse}, {Ordonnee})");
    }
}
