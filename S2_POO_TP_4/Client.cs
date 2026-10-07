using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_4
{
    internal class Client : Person
    {
        List<Car> Cars = new List<Car>();

        public Client(string name, string firstname) : base(name, firstname){
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AfficheCars()
        {
            Console.WriteLine($"Liste de voiture m'appartenant moi {Firstname}, {Name} : ");
            foreach (var item in Cars)
            {
                Console.WriteLine($"Immatriculation : {item.Immatricul}");
            }
        }

        //Donner la voiture au garage
        public void DropOffCar(Garage garage, Car car)
        {
            garage.AddCar(car);
            Cars.Remove(car);
        }

        //Reprendre la voiture du garage, que si le garagiste la réparé.
        public void PickUpCar(Garage garage, Car car)
        {
            garage.
        }
    }
}
