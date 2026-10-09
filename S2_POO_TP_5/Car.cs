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
        [Required]
        public Person Owner { get; }

        public Car(string immatricul, Person owner): base(immatricul)
        {
            Owner = owner;
        }
    }
}
