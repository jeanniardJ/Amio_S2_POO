using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Vehicle
    {
        [Required]
        public string Immatricul { get; set; }

        public string Color { get; set; }

        public int Dommage { get; private set; } = 100;

        public Vehicle(string immatricul)
        {
            Immatricul = immatricul;
        }

        public void SetDommage(int dommage)
        {
            Dommage -= dommage;
        }
    }
}
