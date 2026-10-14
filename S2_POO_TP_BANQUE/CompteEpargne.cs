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

        public CompteEpargne(Client client, decimal depotSomme):base(client)
        {
            if (depotSomme <= SoldeMinimal)
                throw new ArgumentException("Une somme minimal est obligatoir pour ouvrire un compte epargne", nameof(depotSomme));

            Solde = depotSomme;
        }

        public decimal CalculerInterets()
        {
            return Solde * (decimal)TauxInteret;
        }

        public void VerserInterets()
        {

        }
    }
}
