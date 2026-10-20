using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO.Geo_02
{
    internal class Cercle: Forme
    {
        public double Rayon { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rayon"></param>
        /// <example>
        /// 
        /// </example>
        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public override double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }
    }
}
