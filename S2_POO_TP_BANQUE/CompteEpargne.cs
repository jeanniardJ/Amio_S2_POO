using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class CompteEpargne : Compte
    {
        private int SoldeMinimal = 150;
        private double TauxInteret = 0.75;
        private decimal InteretsCumules;

        public CompteEpargne(Client client, DateTime dateDreatedCompte, decimal depotSomme):base(client, dateDreatedCompte)
        {
            if (depotSomme <= SoldeMinimal)
            {
                throw new ArgumentException("Une somme minimal est obligatoir pour ouvrire un compte epargne");
            }

            Solde = depotSomme;
        }

        public decimal CalculerInterets()
        {
            return Solde * (decimal)TauxInteret;
        }

        public void VerserInterets()
        {
            Console.WriteLine($"Intérêt verser à ce jour {CalculerInterets}");

            Crediter(CalculerInterets());
        }
    }
}
