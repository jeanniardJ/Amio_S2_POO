using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Garagiste : Person
    {
       
        //voiture : 1 % = 1h30 * ( 2 - (skills/100))
        // 1% de dégat sur une voiture est égale à 1h30 de réparation,
        // multiplier par (2 - (skill/100)), le skill en pourcentage 
        private int Skills { get; set; }

        private Garage Garage;

        public Garagiste(string name, string firstname, Garage garage) : base(name, firstname)
        {
            Garage = garage;
        }

        public override void Informations()
        {
            Console.WriteLine("Je suis un garagiste !!!");
        }
    }
}
