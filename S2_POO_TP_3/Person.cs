using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_3
{
    internal class Person
    {
        private static int cptInstance;

        private static List<int> Ages = new List<int>();

        public string Name { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

        private List<Car> Cars = new List<Car>();

        //Constructeur
        public Person(string name, string firstName, int age)
        {
            Name = name.ToUpper();
            FirstName = firstName.ToUpper();
            Age = age;

            Ages.Add(age);
            cptInstance++;
        }

        //Destruction 
        ~Person()
        {
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }

        public void Print()
        {
            Console.WriteLine($"Le nom de la personne est {Name}, sont prenom {FirstName} et sont age {Age}.");
            Console.WriteLine("Liste de voiture de la personne : ");
            foreach (var item in Cars)
            {
                Console.WriteLine($"{item.Model}");
            }
        }

        public static double MoyenneAges()
        {
            return (Ages.Count > 0) ? Ages.Average() : 0.0d;
        }

        public static int GetInstance()
        {
            return cptInstance;
        }
    }
}
