using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_4
{
    internal class Car
    {
        [Required]
        public string Immatricul { get; }

        public string Color { get; set; }

        [Required]
        public Person Owner { get; }

        //Construtor
        public Car()
        {
            Color = "White";
        }

        public Car(string immatricul, Person owner)
        {
            Immatricul = immatricul;
            Owner = owner;
        }

    }
}
