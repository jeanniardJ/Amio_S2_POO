using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    public class Compte
    {
        public static int Code { get; private set; } = 1001;

        public int NumorCompte { get; }

        public decimal Solde { get; protected set; } = 0;

        public DateTime DateCreatedCompte { get; } = DateTime.Now;

        public Client Client { get; }

        public static List<Compte> Comptes { get; }  = new List<Compte>();

        //Initialisation d'une instance objet Compte avec le constructor
        public Compte(Client client, DateTime DateCreated, decimal depotSomme = 0)
        {
            Client = client;
            NumorCompte = Code++;
            Solde = depotSomme;
            DateCreatedCompte = DateCreated;

            Comptes.Add(this);//Faire une verif que le compte existe pas déja
        }

        public virtual void Afficher()
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
            Console.WriteLine($"{Comptes.Count()}");
        } 

        public void Crediter(decimal somme)
        {
            Solde += somme;
        }

        //Move somme de compte à compte à faire par l'id du compte
        public void Crediter(decimal somme, int numeroCpt)
        {
            if (Comptes.Find(c => c.NumorCompte == numeroCpt) != null)
            {
                Comptes.Find(c => c.NumorCompte == numeroCpt).Crediter(somme);
                Debiter(somme);
            }
            else
            {
                Console.Error.WriteLine("Error: La somme n'a pas été créditer sur le compte du destinater");
            }
            
        }

        public virtual void Debiter(decimal somme)
        {
            Solde -= somme;
        }

        //Move somme de compte à compte à faire par l'id du compte
        public void Debiter(decimal somme, int numeroCpt)
        {
            //débitant le compte et créditant le compte passé en paramètre
            if(Comptes.Find(c => c.NumorCompte == numeroCpt) != null)
            {
                Comptes.Find(c => c.NumorCompte == numeroCpt).Debiter(somme);
                Crediter(somme);
            }
            else
            {
                Console.Error.WriteLine("Error: La somme n'a pas été débiter sur le compte du destinater");
            }
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
