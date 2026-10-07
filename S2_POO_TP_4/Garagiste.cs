using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace S2_POO_TP_4
{
    internal class Garagiste : Person
    {
        List<Car> Cars = new List<Car>();

        public Garagiste(string name, string firstname) : base(name, firstname){
        }

        public void AddCars(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCars(Car car)
        {
            Cars.Remove(car);
        }
    }
}
