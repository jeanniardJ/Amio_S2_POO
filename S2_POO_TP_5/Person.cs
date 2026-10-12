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

        public void AddVehicle(Vehicle vehicle)
        {
            if (!Vehicles.Contains(vehicle))
            {
                Vehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine("Le véhicule existe déja dans la liste !");
            }
        }

        //Il faut retirer le véhicule dela liste de la personne qui la possede
        public void RemoveVehicule(Vehicle vehicule)
        {
            if (!Vehicles.Contains(vehicule))
            {
                Vehicles.Remove(vehicule);
            }
            else
            {
                Console.WriteLine("Le véhicule n'est en possesion de cette personne !");
            }
        }

        /// <summary>
        /// Méthode pour switcher le véhicule  d'une personne à une autre
        /// </summary>
        /// <param name="person">Est soit une instance garagiste ou client</param>
        /// <param name="vehicle"></param>
        public virtual void TransferVehicleTo(Person person, Vehicle vehicle)
        {
            if (!person.Vehicles.Contains(vehicle))
            {
                person.AddVehicle(vehicle);
                RemoveVehicule(vehicle);
            }
            else
            {
                Console.WriteLine($"Le véhicule est déja en possesion dela personne {person.Firstname} !");
            }
        }

        public Collection<Vehicle> GetVehiclesByOwner()
        {
            return Vehicles;
        }
    }
}
