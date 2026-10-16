using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_POINT
{
    internal class Point
    {
        public double Abscisse { get; set; }
        public double Ordonnee { get; set; }

        public Point(int abs, int ordo)
        {
            Abscisse = abs;
            Ordonnee = ordo;
        }

        public double Norme(int x, int y)
        {
            return Math.Sqrt(Math.Pow((x - Abscisse), 2) * Math.Pow(y- Ordonnee, 2));
        }
    }
}
