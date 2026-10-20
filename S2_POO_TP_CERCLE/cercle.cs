using System.Drawing;

namespace S2_POO_TP_CERCLE;

internal class Cercle
{
    private readonly Point _centre;
    private readonly double _rayon;

    public Cercle(Point centre, double rayon)
    {
        _centre = centre;
        _rayon = rayon;
    }

    public double GetPerimetre()
    {
        return 2 * Math.PI * _rayon;
    }

    public double GetSurface()
    {
        return Math.PI * Math.Pow(_rayon, 2);
    }

    public bool Appartient(Point point)
    {
        double distance_x = Math.Abs(_centre.Abscisse - point.Abscisse);

        double distance_y = Math.Abs(_centre.Ordonnee - point.Ordonnee);

        double distance = Math.Sqrt(distance_x * distance_x + distance_y * distance_y);

        return distance <= _rayon;
    }

    public void Affiche()
    {
        Console.WriteLine($"CERCLE({_centre.Abscisse}, {_centre.Ordonnee}, {_rayon})");
    }
}
