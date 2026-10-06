using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_DES
{
    internal class De
    {
        private int Valeur = 0;
        private static int CptInstan = 1;
        private int Numero = 0;
        
        public De()
        {
            Numero = CptInstan++;
        }

        public int Lancer()
        {
            //retourn une valeur entre 1 à 6
            Valeur = new Random().Next(1, 6);
            
            return Valeur;
        }

        public void Print()
        {
            Console.WriteLine($"Dé n°{Numero} : {Valeur}");
        }
    }
}
