using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_5
{
    internal class Entreprise
    {
        [Required]
        public string Siret { get; private set; }
        [Required]
        public string Name { get;  }

        public Entreprise(string name, string siret) {
            Siret = siret;
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Nom de l'entreprise : {Name}, sont numéro de siret est : {Siret}");
        }
    }
}
