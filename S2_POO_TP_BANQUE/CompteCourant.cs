using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class CompteCourant : Compte
    {
        private int DecouvertAutorise = 300;

        public CompteCourant(Client client, DateTime dateCreated, decimal somme) : base(client, dateCreated, somme)
        {

        }


    }
}
