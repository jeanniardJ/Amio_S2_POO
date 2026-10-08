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
        public string Immatricul { get; }

        public string Color { get; set; }

        [Required]
        public Person Owner { get; }

        public int Dommage { get; set; }
    }
}
