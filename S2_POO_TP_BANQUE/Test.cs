using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class Test
    {
        public Client Client { get; set; }

        public DateTime DateCreatedCpt { get; set; }
        public decimal Somme { get; set; }
        public TypeCompte TypeCompte { get; set; }

        public Test(Client client, DateTime dateDreatedCompte, decimal somme, TypeCompte typeCompte)
        {
            Client = client;
            DateCreatedCpt = dateDreatedCompte;
            Somme = somme;
            TypeCompte = typeCompte;
        }
    }
}
