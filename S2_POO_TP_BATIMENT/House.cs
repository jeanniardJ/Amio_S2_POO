using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BATIMENT
{
    internal class House : Building
    {
        public int NbrRoom { get; }

        House() { }
        public House(string address, int nbrRoom) : base(address) {
            NbrRoom = nbrRoom;
        }

        public override void ToString()
        {
            Console.WriteLine($"La maison a {NbrRoom} piéces et est à cette adresse {Address}");
        }
    }
}
