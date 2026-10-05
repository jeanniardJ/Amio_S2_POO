using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_1
{
    internal class Person
    {
        public string Name;

        public string FirstName;

        public Int32 Age;

        public void Print()
        {
            Console.WriteLine($"Le nom de la personne est {Name}, sont prenom {FirstName} et sont age {Age}.");
        }

    }
}
