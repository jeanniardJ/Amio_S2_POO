namespace S2_POO_TP_BANQUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client[] clients = {
                new Client("AB123456", "Martin", "Jean", "0612345678"),
                new Client("CD789012", "Bernard", "Sophie", "0698765432"),
                new Client("EF345678", "Petit", "Lucas", "0711223344"),
                new Client("GH901234", "Durand", "Emma", "0655443322"),
                new Client("IJ567890", "Leroy", "Hugo", "0788776655"),
                new Client("KL123789", "Moreau", "Léa", "0644556677"),
                new Client("MN456123", "Simon", "Nathan", "0733221100"),
                new Client("OP789456", "Laurent", "Chloé", "0622334455"),
                new Client("QR234567", "Michel", "Louis", "0799887766"),
                new Client("ST678901", "Garcia", "Camille", "0611009988"),
                new Client("UV345678", "Roux", "Manon", "0755667788"),
                new Client("WX901234", "Fournier", "Jules", "0677889900"),
                new Client("YZ123456", "Girard", "Inès", "0744332211"),
                new Client("AB654321", "Mercier", "Arthur", "0688990011"),
                new Client("CD765432", "Lambert", "Jade", "0722110099"),
            };

            Compte[] comptes = {
                // clients[0] → 2 comptes
                new CompteCourant(clients[0], 1500.50m),
                new CompteEpargne(clients[0], 850.00m),

                // clients[1] → 1 compte
                new CompteCourant(clients[1], 230.00m),

                // clients[2] → 2 comptes
                new CompteCourant(clients[2], 4500.75m),
                new CompteEpargne(clients[2], 120.00m),

                // clients[3] → 1 compte
                new CompteCourant(clients[3], 89.99m),

                // clients[4] → 3 comptes
                new CompteCourant(clients[4], 750.25m),
                new CompteCourant(clients[4], 2000.00m),
                new CompteEpargne(clients[4], 562),

                // clients[5] → 1 compte
                new CompteEpargne(clients[5], 50),

                // clients[6] → 2 comptes
                new CompteEpargne(clients[6], 3200.00m),
                new CompteEpargne(clients[6], 450.75m),

                // clients[7] → 1 compte
                new CompteEpargne(clients[7], 150.60m),

                // clients[8] → 2 comptes
                new CompteEpargne(clients[8], 1200.00m),
                new CompteEpargne(clients[8], 60.00m),

                // clients[9] → 1 compte
                new CompteEpargne(clients[9], 50.00m),

                // clients[10] → 2 comptes
                new CompteEpargne(clients[10], 6700.30m),
                new CompteEpargne(clients[10], 340.00m),

                // clients[11] → 1 compte
                new CompteEpargne(clients[11], 150),

                // clients[12] → 1 compte
                new CompteEpargne(clients[12], 280.45m),

                // clients[13] → 2 comptes
                new CompteEpargne(clients[13], 999.99m),
                new Compte(clients[13], 75.50m),

                // clients[14] → 1 compte
                new CompteEpargne(clients[14], 4200.00m),
            };

            foreach(Compte compte in comptes)
            {
                compte.Afficher();
            }

            Console.WriteLine("----------------------------------");

            clients[0].DisplayInfo();

            comptes[0].Afficher();
            comptes[1].Afficher();

            clients[1].DisplayInfo();

            comptes[3].Afficher();

            Compte.NbCompt();

            Console.WriteLine($"\n----------------\n");

            comptes[0].AfficheComptes();



        }
    }
}
