using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_1
{
    internal class Car
    {
        private String Registration;

        private String Model;

        private String Brand;

        private Int32 KLM;

        private DateTime OriginalInServiceDate;

        private Int32 Power;

        private Person Owner;

        public void SetRegistration(string registration)
        {
            Registration = registration;
        }

        public string GetRegistration()
        {
            return Registration;
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public string GetModel()
        {
            return Model;
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public void SetKLM(int kml)
        {
            KLM = kml;
        }

        public int GetKLM()
        {
            return KLM;
        }

        public void SetOriginalInServiceDate(DateTime originalInServiceDate)
        {
            OriginalInServiceDate = originalInServiceDate;
        }

        public DateTime GetOriginalInServiceDate()
        {
            return OriginalInServiceDate;
        }

        public void SetPower(int power)
        {
            Power = power;
        }

        public int GetPower()
        {
            return Power;
        }

        public void AddOwner(Person person)
        {
            Owner = person;
        }

        public void RemoveOwner()
        {
            Owner = null;
        }

        public void Print()
        {
            Console.WriteLine($"La voiture a été enregistre le {Registration}, à pour modele : {Model}, la plaque est {Brand}, le kilometrage est {KLM}, la date de mise en service est : {OriginalInServiceDate}, le nombre de chevaux : {Power} et elle appartient à {Owner.GetName()}");
        }
    }
}
