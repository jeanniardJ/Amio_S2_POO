using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_BANQUE
{
    internal class Compte
    {
        public static int Code = 1;

        public int NumorCompte { get; }

        public decimal Solde { get; private set; } = 0;

        public Client Client { get; }

        public Compte(Client client)
        {
            Client = client;
            NumorCompte = Code++;
        }

        public void Afficher()
        {
            string info = $"Le numéro de compte est {NumorCompte},\n";
            info += $"\tSon solde est : {Solde}\n";
            info += $"\tAppartient à {Client.FirstName} {Client.LastName}\n";
            info += $"\tCIN : {Client.CIN}\n";
            info += $"\tTél : {Client.Tel}\n";

            Console.WriteLine(info);
        }

        public static void NbCompt()
        {
            Console.WriteLine($"{Code-1}");
        } 

        public void Crediter(decimal somme)
        {
            Solde += somme;
        }

        //Move somme de compte à compte
        public void Crediter(decimal somme, Compte compte)
        {
            compte.Crediter(somme);
            Solde -= somme; 
        }

        public void Debiter(decimal somme)
        {
            Solde -= somme;
        }

        public void Debiter(decimal somme, Compte compte)
        {
            //débitant le compte et créditant le compte passé en paramètre
            compte.Debiter(somme);
            Solde += somme;
        }
    }
}
