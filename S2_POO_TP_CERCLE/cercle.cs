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
            Console.WriteLine($"Le périmètre du cercle est :  {(2*Math.PI*Rayon)}");
        }

        public void GetSurface()
        {
            Console.WriteLine($"La surface est : {(Math.PI * Math.Pow(Rayon, 2))}");
        }

        public bool Appartient(Point p)
        {
            //Verifier que les abs et les ordonnées de cercle et de point sont les même.
            if(p.Abscisse == Ordonnee && p.Ordonnee == Rayon)
                return true;

            return false;
        }

        public void Affiche()
        {
            Console.WriteLine($"CERCLE({Abscisse}, {Ordonnee}, {Rayon})");
        }
    }
}
