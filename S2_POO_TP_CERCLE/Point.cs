namespace S2_POO_TP_CERCLE;

internal class Point
{
    public float Abscisse { get; private set; }
    public float Ordonnee { get; }

    public Point(int x, int y)
    {
        Abscisse = x;
        Ordonnee = y;
    }

    public void Afficher()
    {
        Console.WriteLine($"POINT({Abscisse},{Ordonnee})");
    }
}
