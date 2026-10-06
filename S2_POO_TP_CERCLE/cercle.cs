using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_CERCLE
{
    internal class Cercle
    {
        private int Abscisse;
        private int Ordonnee;
        private int Rayon;

        public Cercle(int x, int y , int rayon)
        {
            Abscisse = x;
            Ordonnee = y;
            Rayon = rayon;
        }

        public void GetPerimetre()
        {

        }

        public void GetSurface()
        {

        }

        public bool Appartient(Point p)
        {
            return true;
        }

        public void Affiche()
        {

        }
    }
}
