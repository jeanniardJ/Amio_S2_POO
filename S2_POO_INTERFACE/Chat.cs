using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_INTERFACE
{
    internal class Chat : IAnimal
    {
        public void FaireDuBruit()
        {
            Console.WriteLine("Le chat mioul.");
        }

        public void Manger()
        {
            Console.WriteLine("Le chat mange du poisson !");
        }
    }
}
