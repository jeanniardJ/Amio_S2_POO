using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_POLYMORPH
{
    internal class Animal : IAnimal
    {
        public virtual void FaireDuBruit()
        {
            Console.WriteLine("L'animal fait du bruit");
        }
    }
}
