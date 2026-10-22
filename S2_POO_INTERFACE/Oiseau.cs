using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_INTERFACE
{
    internal class Oiseau : IAnimal, IVolant
    {
        public void FaireDuBruit()
        {
            Console.WriteLine("Fait cuicui.");
        }

        public void Manger()
        {
            Console.WriteLine("Mange des graine.");
        }

        public void Voler()
        {
            Console.WriteLine("L'oiseau vole.");
        }
    }
}
