using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Garagiste : Person
    {
        private List<Car> Cars = new List<Car>();

        public Garage Garage { get; }

        public Garagiste(string name, string firstname, Garage garage) : base(name, firstname)
        {
            Garage = garage;
        }

        public void AfficheCars()
        {
            Console.WriteLine($"Liste de voiture en possession du garagiste {Firstname} {Name} : ");
            foreach (Car item in Cars)
            {
                Console.WriteLine($"Immatriculation : {item.Immatricul}");
            }
        }

        public void AddCars(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCars(Car car)
        {
            Cars.Remove(car);
            Garage.AddCar(car);
        }

        public override void Informations()
        {
            Console.WriteLine("Je suis un garagiste !!!");
        }
    }
}
