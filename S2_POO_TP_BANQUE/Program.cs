namespace S2_POO_TP_BANQUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client clientA = new("5465656", "Doe", "John", "06.54.58.85.20");
            Client clientB = new("5651564", "Martin", "Jean", "06.54.58.85.20");

            Compte compteA = new(clientA);
            Compte compteB = new(clientA);

            Compte compteC = new(clientB);

            clientA.DisplayInfo();

            compteA.Afficher();
            compteB.Afficher();

            clientB.DisplayInfo();

            compteC.Afficher();

            Compte.NbCompt();

            Console.WriteLine($"\n----------------\n");

            compteA.Crediter(10000);

            compteA.Afficher();

            compteA.Debiter(100);

            compteA.Afficher();

            compteA.Crediter(200, compteB);

            compteA.Afficher();

            compteB.Afficher();
        }
    }
}
