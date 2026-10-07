using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_4
{
    //classe dérivée
    internal class Garage : Entreprise
    {
        private List<Car> Cars = new List<Car>();
        private List<Garagiste> Garagistes = new List<Garagiste>();

        public Garage(string name, string siret) : base(name, siret){
        }
        
        public override void Print()
        {
            //base.Print();
            Console.WriteLine($"Le nom de mon entreprise est {Name} et mon numéro de siret est : {Siret}");
        }

        //Ajoute un garagiste au garage
        public void AddGaragiste(Garagiste garagiste)
        {
            Garagistes.Add(garagiste);
        }

        //Gére la liste de voiture à reparer 
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AfficheCars()
        {
            Console.WriteLine("Liste des voitures en attent de reparations : ");
            foreach (var item in Cars)
            {
                Console.WriteLine($"Immatricule : {item.Immatricul}");
            }
        }

        //Assigner la voiture à un garagiste
        public void AssignToGaragiste(Garagiste garagiste, Car car)
        {
            garagiste.AddCars(car);
            Cars.Remove(car);
        }

        public static void Repeindre(Car voitureA, string color)
        {
            voitureA.Color = color;
        }
    }
}
