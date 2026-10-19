using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO.Animals
{
    internal abstract class Animal
    {
        public string Nom { get; set; }

        public void Manger()
        {
            Console.WriteLine("L'animal mange.");
        }

        public abstract void FaireDuBruit();
    }
}
