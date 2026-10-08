using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Car : Vehicle
    {
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
