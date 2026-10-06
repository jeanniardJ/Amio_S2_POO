using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_3
{
    internal class Car
    {
        public String Registration { get; set; }

        public String Model { get; set; }

        public List<String> Brands = new List<string>();

        public Int32 KLM { get; set; }

        public DateTime OriginalInServiceDate { get; set; }

        public Int32 Power { get; set; }

        private Person Owner;

        public Car(String registration, string model, int kml, DateTime origineInServiceDate, int power)
        {
            Registration = registration;
            Model = model;
            KLM = kml;
            OriginalInServiceDate = origineInServiceDate;
            Power = power;
        }

        ~Car() { }

        public void AddOwner(Person person)
        {
            Owner = person;
        }

        public void RemoveOwner()
        {
            Owner = null;
        }

        public void AddBrand(string brand)
        {
            if (Brands.Exists(w => w.Equals(brand)))
            {
                Brands.Add("");
            }
            else
            {
                Brands.Add(brand);
            }

        }

        public void Print()
        {
            Console.WriteLine($"La voiture a été enregistre en {Registration}, à pour modele : {Model}, le kilometrage est {KLM}, la date de mise en service est : {OriginalInServiceDate}, le nombre de chevaux : {Power} et elle appartient à {Owner.Name}");
            foreach (var item in Brands)
            {
                Console.WriteLine($"Numéro d'immatriculation : {item}");
            }
        }
    }
}
