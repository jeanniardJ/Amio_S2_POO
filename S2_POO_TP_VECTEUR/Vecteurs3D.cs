using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_VECTEUR
{
    internal class Vecteurs3D : Vecteurs2D
    {
        public double Cote { get; }

        public Vecteurs3D(Vecteurs3D vecteurs3D)
        {
            Abscisse = vecteurs3D.Abscisse;
            Ordonne = vecteurs3D.Ordonne;
            Cote = vecteurs3D.Cote;
            NbrVecteur = vecteurs3D.NbrVecteur;
        }

        public Vecteurs3D(double abscisse, double ordonne, double cote, int nbrVecteur) : base(abscisse, ordonne, nbrVecteur)
        {
            Cote = cote;
        }

        public override void ToString()
        {
            Console.WriteLine($"X = {Abscisse} - Y = {Ordonne} - Z = {Cote}");
        }

        public virtual bool Equals()
        {
            return Abscisse == Ordonne && Abscisse == Cote ? true : false;
        }

        public virtual double Norme()
        {
            return Math.Sqrt(Math.Pow(Abscisse, 2) + Math.Pow(Ordonne, 2) + Math.Pow(Cote, 2));
        }
    }
}
