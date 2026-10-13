using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_VECTEUR
{
    internal class Vecteurs2D
    {
        public double Abscisse { get; set; }
        public double Ordonne { get; set; }
        public int NbrVecteur { get; set; }

        public Vecteurs2D() { }

        public Vecteurs2D(Vecteurs2D vecteurs2D)
        {
            Abscisse = vecteurs2D.Abscisse;
            Ordonne = vecteurs2D.Ordonne;
            NbrVecteur = vecteurs2D.NbrVecteur;
        }

        public Vecteurs2D(double abscisse, double ordonne, int nbrVecteur)
        {
            Abscisse = abscisse;
            Ordonne = ordonne;
            NbrVecteur = nbrVecteur;
        }

        public virtual void ToString()
        {
            Console.WriteLine($"X = {Abscisse} - Y = {Ordonne}");
        }

        public virtual bool Equals()
        {
            return Abscisse == Ordonne ? true : false;
        }

        public virtual double Norme() {
            return Math.Sqrt(Math.Pow(Abscisse,2) + Math.Pow(Ordonne,2));
        }
    }
}
