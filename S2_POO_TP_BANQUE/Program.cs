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
                new Compte(1001, clients[0], 1500.50m),
                new Compte(1002, clients[0], 850.00m),

                // clients[1] → 1 compte
                new Compte(1003, clients[1], 230.00m),

                // clients[2] → 2 comptes
                new Compte(1004, clients[2], 4500.75m),
                new Compte(1005, clients[2], 120.00m),

                // clients[3] → 1 compte
                new Compte(1006, clients[3], 89.99m),

                // clients[4] → 3 comptes
                new Compte(1007, clients[4], 750.25m),
                new Compte(1008, clients[4], 2000.00m),
                new Compte(1009, clients[4]),

                // clients[5] → 1 compte
                new Compte(1010, clients[5]),

                // clients[6] → 2 comptes
                new Compte(1011, clients[6], 3200.00m),
                new Compte(1012, clients[6], 450.75m),

                // clients[7] → 1 compte
                new Compte(1013, clients[7], 150.60m),

                // clients[8] → 2 comptes
                new Compte(1014, clients[8], 1200.00m),
                new Compte(1015, clients[8], 60.00m),

                // clients[9] → 1 compte
                new Compte(1016, clients[9], 50.00m),

                // clients[10] → 2 comptes
                new Compte(1017, clients[10], 6700.30m),
                new Compte(1018, clients[10], 340.00m),

                // clients[11] → 1 compte
                new Compte(1019, clients[11]),

                // clients[12] → 1 compte
                new Compte(1020, clients[12], 280.45m),

                // clients[13] → 2 comptes
                new Compte(1021, clients[13], 999.99m),
                new Compte(1022, clients[13], 75.50m),

                // clients[14] → 1 compte
                new Compte(1023, clients[14], 4200.00m),
            };

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
