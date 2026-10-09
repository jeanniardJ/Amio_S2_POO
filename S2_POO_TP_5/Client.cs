using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Client : Person
    {

        public Client(string name, string firstname, Vehicle vehicle) : base(name, firstname)
        {

        }

        public override void Informations()
        {
            Console.WriteLine("Je suis un client !!!");
        }
    }
}
