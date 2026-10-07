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
            //Verifier que la voiture est toujours en possession du client
            garage.AddCar(car);
            Cars.Remove(car);
        }

        //Reprendre la voiture du garage, que si le garagiste la réparé.
        public void PickUpCar(Garage garage, Car car)
        {
            //Attention à verifier que l'objet est de nouveau dans la liste de cars dans garage
            //(il faut que le garagiste es rendu la voiture au garage)
            if (garage.Cars.Contains(car))
            {
                garage.RemoveCar(car);
                Cars.Add(car);
                Console.WriteLine("La voiture à été recuperer !");
            }
            else
            {
                Console.WriteLine("La voiture est toujour en reparation !");
            }
            
        }
    }
}
