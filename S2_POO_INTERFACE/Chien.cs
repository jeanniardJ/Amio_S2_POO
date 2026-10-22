using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_INTERFACE
{
    internal class Chien : IAnimal
    {
        public void FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie.");
        }

        public void Manger()
        {
            Console.WriteLine("Le chien mange.");
        }
    }
}
