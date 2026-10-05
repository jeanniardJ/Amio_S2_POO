using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_1
{
    internal class Car
    {
        public String Registration;

        public String Model;

        public String Brand;

        public Int32 KLM;

        public DateTime OriginalInServiceDate;

        public Int32 Power;

        public Person owner;

        public void Print()
        {
            Console.WriteLine($"La voiture a été enregistre le {Registration}, à pour modele : {Model}, la plaque est {Brand}, le kilometrage est {KLM}, la date de mise en service est : {OriginalInServiceDate}, le nombre de chevaux : {Power} et elle appartient à {owner.Name}");
        }
    }
}
