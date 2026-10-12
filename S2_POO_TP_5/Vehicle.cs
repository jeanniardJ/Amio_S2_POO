using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Vehicle
    {
        [Required]
        public string Immatricul { get; set; }

        public string Color { get; set; }

        public int Dommage { get; private set; } = 0;

        [Required]
        public Person Owner { get; }

        public Vehicle(string immatricul, Person owner)
        {
            Immatricul = immatricul;
            Owner = owner;
            Color = "Black";

            owner.AddVehicle(this);
        }

        //Ajoute des dégats au véhicule
        public void SetDommage(int dommage)
        {
            Dommage -= dommage;
        }
    }
}
