using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_ANIMAUX
{
    internal class Chien: Animal
    {
        public Chien(string name, string color, double weight):base(name, color, weight)
        {

        }

        public override string FaireUnSon()
        {
            return "Je fais wouaf";
        }
    }
}
