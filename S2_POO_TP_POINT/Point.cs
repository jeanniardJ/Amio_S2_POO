namespace S2_POO_TP_POINT;

internal class Point
{
    public double Abscisse { get; private set; }
    public double Ordonne { get; private set; }

    public Point(int abscisse, int ordonne)
    {
        Abscisse = abscisse;
        Ordonne = ordonne;
    }

    public double Norme()
    {
        return Math.Sqrt(Math.Pow((Abscisse), 2) + Math.Pow(Ordonne, 2));
    }
}
