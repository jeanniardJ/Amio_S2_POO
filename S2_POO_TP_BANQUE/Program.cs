using System.Numerics;

namespace S2_POO_TP_BANQUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client clA = new("AB123456", "Martin", "Jean", "0612345678");
            Client clB = new("CD789012", "Bernard", "Sophie", "0698765432");

            Console.WriteLine(clA.ToString());
            Console.WriteLine(clB.ToString());

            Compte cptA = new Compte(clA, new DateTime(2026, 1, 15), 1500.50m);
            Compte cptB = new Compte(clB, new DateTime(2026, 2, 10), 0m);

            Console.WriteLine(cptA.ToString());
            Console.WriteLine(cptB.ToString());

            CompteCourant cptCtA = new CompteCourant(clA, new DateTime(2025, 1, 15), 1500.50m);
            CompteCourant cptCtB = new CompteCourant(clB, new DateTime(2025, 2, 20), -200.00m);

            Console.WriteLine(cptCtA.ToString());
            Console.WriteLine(cptCtB.ToString());

            CompteEpargne cptEpA = new CompteEpargne(clA, new DateTime(2024, 1, 10), 5000.00m);
            CompteEpargne cptEpB = new CompteEpargne(clB, new DateTime(2024, 2, 14), 12000.50m);

            Console.WriteLine(cptEpA);
            Console.WriteLine(cptEpB);



        }
    }
}
