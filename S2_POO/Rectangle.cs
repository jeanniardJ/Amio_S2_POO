using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO
{
    public class Rectangle
    {
        public double hauteur;
        public double largeur;

        public double surface(double hauteur, double largeur)
        {
            return hauteur * largeur;
        }

        public void affiche(double hauteur, double largeur, double surface)
        {
            Console.WriteLine($"Je suis un rectangle de hauteur {hauteur} et de largeur {largeur}.");
            Console.WriteLine($"Ma surface est de {surface}.");
        }
    }
}
