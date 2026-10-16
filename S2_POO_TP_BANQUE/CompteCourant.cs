using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    public class CompteCourant : Compte
    {
        private int DecouvertAutorise = 300;

        public CompteCourant(Client client, DateTime dateCreated, decimal somme) : base(client, dateCreated, somme)
        {

        }

        public override void Afficher()
        {
            string info = $"\tLe type de compte est : {this.GetType().Name}\n";

            base.Afficher();

            Console.WriteLine(info);
        }

        //ajouter la condition de l'autorisation de découvert
        public override void Debiter(decimal somme)
        {
            if (DecouvertAutorise <= somme - Solde)
            {
                Console.WriteLine($"{somme - Solde}");
                throw new Exception("Le retrait dépasse le découvert autoriser !");
            }

            Solde -= somme;
        }
    }
}
