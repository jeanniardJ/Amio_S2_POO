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

        private List<Vehicle> VehiclesToRepair = new List<Vehicle>();

        public Garage(string name, string siret) : base(name, siret){

        }
        
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

            if(!VehiclesToRepair.Contains(vehicle))
            {
                VehiclesToRepair.Add(vehicle);
                //Il faut déposseder la person qui a le véhicule 
            }
            else
            {
                Console.WriteLine("Le véhicule est déja possedé par le garage !");
            }
        }

        private void AssignVehicleToMechanic()
        {

        }
    }
}
