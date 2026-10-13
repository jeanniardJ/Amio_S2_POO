using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    //classe dérivée
    internal class Garage : Entreprise
    {
        private List<Garagiste> Garagistes = new List<Garagiste>();

        private int TimeRepairCar = 90;

        private int TimeRepairTruck = 120;

        public Garage(string name, string siret) : base(name, siret) { }

        public override void Print()
        {
            Console.WriteLine($"Le nom de mon entreprise est {Name} et mon numéro de siret est : {Siret}");
        }

        public void AddGaragiste(Garagiste garagiste)
        {
            if (!Garagistes.Contains(garagiste))
            {
                Garagistes.Add(garagiste);
            }
            else
            {
                Console.WriteLine("Le garagiste existe déja dans ce garage !");
            }
        }

        public List<Garagiste> ListGaragistes()
        {
            return Garagistes;
        }

        public void DropOffVehicleForRepair(Vehicle vehicle)
        {
            //Recherche si le véhicule est déja en possesion d'un garagiste
            //Verifier si le véhicule est réparable (si 0 null besoin), on l'assigne à un garagiste (si il existe), 
            if (vehicle.Dommage != 0)
            {
                if (Garagistes.Where(g => g.GetVehiclesByOwner().Contains(vehicle)).Count() == 0)
                {
                    Garagiste garagiste = AssignVehicleToMechanic(vehicle);

                    vehicle.Owner.TransferVehicleTo(garagiste, vehicle);
                }
                else
                {
                    Console.WriteLine("Le véhicule est déja possedé par le garage !");
                }
            }
            else
            {
                Console.WriteLine("Le véhicule n'a pas besoin de réparation !");
            }
        }

        private Garagiste AssignVehicleToMechanic(Vehicle vehicle)
        {
            Random random = new Random();
            int index = random.Next(0, Garagistes.Count);
            //Randomiser l'assignation d'un véhicule à un garagiste
            return Garagistes[index];
        }

        public void GetVehiclesInRepair()
        {
            //Je retourne les garagistes qui on un véhicule en leurs possesion à reparer 
            foreach (Garagiste garagistes in Garagistes.Where(g => g.GetVehiclesByOwner() != null))
            {
                Console.WriteLine($"Le garagiste {garagistes.Name} a ces véhicules : ");
                foreach (Vehicle vehicle in garagistes.GetVehiclesByOwner())
                {
                    Console.WriteLine($"Immatriculation : {vehicle.Immatricul}");
                    //Estimation de temps pour la reparation
                    int timeRepair = vehicle.GetType().Name == "Car" ? (vehicle.Dommage * TimeRepairCar) * (2 - (garagistes.Skills / 100)) : (vehicle.Dommage * TimeRepairTruck) * (2 - (garagistes.Skills / 100));
                    Console.WriteLine($"Temp donner pour réparer le véhicule : {timeRepair} minute(s)");
                }
            }
        }

        //Méthode de calcul du temps de réparation du véhicule
    }
}
