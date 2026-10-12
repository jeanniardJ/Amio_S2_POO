using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Client : Person
    {

        public Client(string name, string firstname) : base(name, firstname)
        {

        }

        public override void Print()
        {
            Console.WriteLine($"Mon nom est {Name} et mon prénom est {Firstname}");
        }

        public override void Informations()
        {
            Console.WriteLine("Je suis un client !!!");
        }
    }
}
