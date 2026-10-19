using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO.Geo_02
{
    internal class Rectangle : Forme
    {
        public double Longueur { get; }
        public double Largeur { get; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override double CalculerAire()
        {
            return Longueur * Largeur;
        }
    }
}
