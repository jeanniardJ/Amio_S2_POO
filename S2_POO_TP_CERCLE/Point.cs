using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_CERCLE
{
    internal class Point
    {
        private float Abscisse;
        private float Ordonnee;

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
}
