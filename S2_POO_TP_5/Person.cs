using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Person
    {
        [Required]
        public string Name { get; }

        [Required]
        public string Firstname { get; }

        private Collection<Vehicle> Vehicles = new Collection<Vehicle>();
        
        public Person(string name, string firstname)
        {
            Name = name;
            Firstname = firstname;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Mon nom est {Name} et mon prénom est {Firstname}");
        }

        public virtual void Informations()
        {
            Console.WriteLine("Je suis une personne !!!");
        }


    }
}
