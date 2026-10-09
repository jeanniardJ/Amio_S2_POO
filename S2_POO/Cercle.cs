using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO
{
    internal class Cercle
    {
        private int Rayon;

        public Cercle(Cercle cercle)
        {
            Rayon = cercle.Rayon;
        }

        public bool GetRayon(string message)
        {
            Console.WriteLine($"Sont rayon {this.Rayon}, {message}");
            return true;
        }

        public int GetRayon()
        {
            return this.Rayon;
        }



       
    }
}
