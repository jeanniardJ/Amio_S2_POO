using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_1
{
    internal class Person
    {
        private string Name;

        private string FirstName;

        private Int32 Age;

        private List<Car> Cars = new List<Car>();

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetAge()
        {
            return Age;
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
                Console.WriteLine($"{item.GetModel()}");
            }
        }

    }
}
