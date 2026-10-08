using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_POLYMORPH
{
    internal class Chien : Animal
    {
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie.");
        }
    }
}
