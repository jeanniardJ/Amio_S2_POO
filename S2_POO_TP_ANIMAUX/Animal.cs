using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_ANIMAUX
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public double Weight { get; set; }

        public Animal(string name, string color, double weight)
        {
            Name = name;
            Color = color;
            Weight = weight;
        }

        public override string ToString()
        {
            return base.ToString() + ": \n\t" + Name + "\n\t" + Color + "\n\t" + Weight + "\n\t" + FaireUnSon();
        }

        public abstract string FaireUnSon();
    }
}
