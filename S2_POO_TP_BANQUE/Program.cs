using System.Numerics;

namespace S2_POO_TP_BANQUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CompteCourant> comptesCourants = new();
            List<CompteEpargne> comptesEpargnes = new();

            var random = new Random();
            DateTime DateAleatoire() => DateTime.Now.AddDays(-random.Next(0, 365));

            Test[] datas = {
                new Test(clients[0], DateAleatoire(), 850.00m, TypeCompte.CompteEpargne),
                new Test(clients[0], DateAleatoire(), 1500.50m, TypeCompte.CompteCourant),
                new Test(clients[1], DateAleatoire(), 230.00m, TypeCompte.CompteCourant),
                new Test(clients[2], DateAleatoire(), 4500.75m, TypeCompte.CompteCourant),
                new Test(clients[2], DateAleatoire(), 120.00m, TypeCompte.CompteEpargne),
                new Test(clients[3], DateAleatoire(), 89.99m, TypeCompte.CompteCourant),
                new Test(clients[4], DateAleatoire(), 750.25m, TypeCompte.CompteCourant),
                new Test(clients[4], DateAleatoire(), 2000.00m, TypeCompte.CompteCourant),
                new Test(clients[4], DateAleatoire(), 562.00m, TypeCompte.CompteEpargne),
                new Test(clients[5], DateAleatoire(), 50.00m, TypeCompte.CompteEpargne),
                new Test(clients[6], DateAleatoire(), 3200.00m, TypeCompte.CompteEpargne),
                new Test(clients[6], DateAleatoire(), 450.75m, TypeCompte.CompteEpargne),
                new Test(clients[7], DateAleatoire(), 150.60m, TypeCompte.CompteEpargne),
                new Test(clients[8], DateAleatoire(), 1200.00m, TypeCompte.CompteEpargne),
                new Test(clients[8], DateAleatoire(), 60.00m, TypeCompte.CompteEpargne),
                new Test(clients[9], DateAleatoire(), 50.00m, TypeCompte.CompteEpargne),
                new Test(clients[10], DateAleatoire(), 6700.30m, TypeCompte.CompteEpargne),
                new Test(clients[10], DateAleatoire(), 340.00m, TypeCompte.CompteEpargne),
                new Test(clients[11], DateAleatoire(), 150.00m, TypeCompte.CompteEpargne),
                new Test(clients[12], DateAleatoire(), 280.45m, TypeCompte.CompteEpargne),
                new Test(clients[13], DateAleatoire(), 999.99m, TypeCompte.CompteEpargne),
                new Test(clients[13], DateAleatoire(), 75.50m, TypeCompte.CompteCourant),
                new Test(clients[14], DateAleatoire(), 4200.00m, TypeCompte.CompteEpargne),
            };

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"Nombre de compte demander : {datas.Count()}");

            Thread.Sleep(1000);
            Console.WriteLine("----------------------------------");

            foreach (Test item in datas)
            {
                try
                {
                    if (item.TypeCompte == TypeCompte.CompteCourant)
                    {
                        comptesCourants.Add(new CompteCourant(item.Client, item.DateCreatedCpt, item.Somme));
                    }
                    else
                    {
                        comptesEpargnes.Add(new CompteEpargne(item.Client, item.DateCreatedCpt, item.Somme));
                    }

                    Console.WriteLine($"Compte créé au nom de {item.Client.LastName}, date de creation du compte {item.DateCreatedCpt}, somme déposer {item.Somme} et le type de compte est : {item.TypeCompte}");
                }
                catch (ArgumentException e)
                {
                    Console.Error.WriteLine($"Erreur : {e}");
                    Thread.Sleep(2000);
                }
                catch(OperationCanceledException)
                {
                    Console.WriteLine("Processing is cancelled.");
                }

                Thread.Sleep(1000);
            }

            Console.Clear();

            Console.WriteLine("---- Compte courant ----");
            foreach (Compte compte in comptesCourants)
            {
                Console.WriteLine("----------------------------------");
                
                compte.Afficher();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------");
                Console.Clear();
            }

            Console.WriteLine("---- Compte épargne ----");
            foreach (Compte compte in comptesEpargnes)
            {
                Console.WriteLine("----------------------------------");

                compte.Afficher();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------");
                Console.Clear();
            }

            Console.WriteLine("---- Compte ----");
            foreach (Compte compte in Compte.Comptes)
            {
                Console.WriteLine("----------------------------------");

                compte.Afficher();
                Thread.Sleep(1000);
                Console.WriteLine("----------------------------------");
                Console.Clear();
            }
        }
    }
}
