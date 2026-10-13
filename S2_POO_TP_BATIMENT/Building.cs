using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BATIMENT
{
    internal class Building
    {
        public string Address { get; }

        public Building() { }

        public Building(string address) {
            Address = address;
        }

        public virtual void ToString()
        {
            Console.WriteLine($"Le bâtiment est à l'adresse {Address}");
        }
    }
}
