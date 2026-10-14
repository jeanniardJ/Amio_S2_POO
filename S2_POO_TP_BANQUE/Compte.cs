using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class Compte
    {
        public static int Code { get; private set; } = 0;

        public int NumorCompte { get; }

        public decimal Solde { get; private set; } = 0;

        public DateTime DateCreatedCompte { get; } = DateTime.Now;

        public Client Client { get; }

        private static List<Compte> Comptes = new List<Compte>();

        //Initialisation d'une instance objet Compte avec le constructor
        public Compte(int numeroCpt, Client client, decimal depotSomme = 0)
        {
            Code++;

            Client = client;
            NumorCompte = numeroCpt;
            Solde = depotSomme;

            Comptes.Add(this);//Faire une verif que le compte existe pas déja
        }

        public void Afficher()
        {
            string info = $"Le numéro de compte est {NumorCompte},\n";
            info += $"\tSon solde est : {Solde}\n";
            info += $"\tDate de création du compte {DateCreatedCompte}\n";
            info += $"\tAppartient à {Client.FirstName} {Client.LastName}\n";
            info += $"\tCIN : {Client.CIN}\n";
            info += $"\tTél : {Client.Tel}\n";

            Console.WriteLine(info);
        }

        public static void NbCompt()
        {
            Console.WriteLine($"{Code}");
        } 

        public void Crediter(decimal somme)
        {
            Solde += somme;
        }

        //Move somme de compte à compte à faire par l'id du compte
        public void Crediter(decimal somme, Compte compte)
        {
            compte.Crediter(somme);
            Solde -= somme; 
        }

        public void Debiter(decimal somme)
        {
            Solde -= somme;
        }

        //Move somme de compte à compte à faire par l'id du compte
        public void Debiter(decimal somme, Compte compte)
        {
            //débitant le compte et créditant le compte passé en paramètre
            compte.Debiter(somme);
            Solde += somme;
        }

        public void AfficheComptes()
        {
            foreach (var item in Comptes.Where(c => c.Client == Client))
            {
                item.Afficher();
            }
        }
    }
}
