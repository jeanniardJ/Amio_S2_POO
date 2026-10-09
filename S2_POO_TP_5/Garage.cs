using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    //classe dérivée
    internal class Garage : Entreprise
    {
        private List<Garagiste> Garagistes = new List<Garagiste>();

        public Garage(string name, string siret) : base(name, siret){

        }
        
        public override void Print()
        {
            Console.WriteLine($"Le nom de mon entreprise est {Name} et mon numéro de siret est : {Siret}");
        }

        public AddGaragiste(Garagiste)
        {
            if(Garagistes.Contains())
        }

    }
}
