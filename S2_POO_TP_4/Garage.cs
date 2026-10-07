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

        public void AddGaragiste(Garagiste garagiste)
        {
            Garagistes.Add(garagiste);
        }

        //Gére la liste de voiture à reparer et assigner la voiture à un garagiste
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AssignToGaragiste(Car car)
        {

        }

        public static void Repeindre(Car voitureA, string color)
        {
            voitureA.Color = color;
        }
    }
}
