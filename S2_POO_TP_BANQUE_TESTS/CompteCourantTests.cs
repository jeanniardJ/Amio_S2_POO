using S2_POO_TP_BANQUE;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;

namespace S2_POO_TP_BANQUE_TESTS
{
    [TestClass]
    public sealed class CompteCourantTests
    {
        Client[] clients = {
                new ("AB123456", "Martin", "Jean", "0612345678"),
                new ("CD789012", "Bernard", "Sophie", "0698765432"),
                new ("EF345678", "Petit", "Lucas", "0711223344"),
                new ("GH901234", "Durand", "Emma", "0655443322"),
                new ("IJ567890", "Leroy", "Hugo", "0788776655"),
                new ("KL123789", "Moreau", "Léa", "0644556677"),
                new ("MN456123", "Simon", "Nathan", "0733221100"),
                new ("OP789456", "Laurent", "Chloé", "0622334455"),
                new ("QR234567", "Michel", "Louis", "0799887766"),
                new ("ST678901", "Garcia", "Camille", "0611009988"),
                new ("UV345678", "Roux", "Manon", "0755667788"),
                new ("WX901234", "Fournier", "Jules", "0677889900"),
                new ("YZ123456", "Girard", "Inès", "0744332211"),
                new ("AB654321", "Mercier", "Arthur", "0688990011"),
                new ("CD765432", "Lambert", "Jade", "0722110099"),
            };

        Random random = new Random();
        DateTime DateAleatoire() => DateTime.Now.AddDays(-random.Next(0, 365));

        //Test[] datas = {
        //        new Test(clients[0], DateAleatoire(), 850.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[0], DateAleatoire(), 1500.50m, TypeCompte.CompteCourant),
        //        new Test(clients[1], DateAleatoire(), 230.00m, TypeCompte.CompteCourant),
        //        new Test(clients[2], DateAleatoire(), 4500.75m, TypeCompte.CompteCourant),
        //        new Test(clients[2], DateAleatoire(), 120.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[3], DateAleatoire(), 89.99m, TypeCompte.CompteCourant),
        //        new Test(clients[4], DateAleatoire(), 750.25m, TypeCompte.CompteCourant),
        //        new Test(clients[4], DateAleatoire(), 2000.00m, TypeCompte.CompteCourant),
        //        new Test(clients[4], DateAleatoire(), 562.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[5], DateAleatoire(), 50.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[6], DateAleatoire(), 3200.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[6], DateAleatoire(), 450.75m, TypeCompte.CompteEpargne),
        //        new Test(clients[7], DateAleatoire(), 150.60m, TypeCompte.CompteEpargne),
        //        new Test(clients[8], DateAleatoire(), 1200.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[8], DateAleatoire(), 60.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[9], DateAleatoire(), 50.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[10], DateAleatoire(), 6700.30m, TypeCompte.CompteEpargne),
        //        new Test(clients[10], DateAleatoire(), 340.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[11], DateAleatoire(), 150.00m, TypeCompte.CompteEpargne),
        //        new Test(clients[12], DateAleatoire(), 280.45m, TypeCompte.CompteEpargne),
        //        new Test(clients[13], DateAleatoire(), 999.99m, TypeCompte.CompteEpargne),
        //        new Test(clients[13], DateAleatoire(), 75.50m, TypeCompte.CompteCourant),
        //        new Test(clients[14], DateAleatoire(), 4200.00m, TypeCompte.CompteEpargne),
        //    };

        [TestMethod]
        public void Debiter_UpdatesBalance()
        {
            decimal beginningBalance = 1500.50m;
            decimal debitAmount = 1600.58m;
            decimal expected = beginningBalance - debitAmount;

            CompteCourant compteCourant = new(clients[0], DateAleatoire(), beginningBalance);

            compteCourant.Debiter(debitAmount);

            decimal actual = compteCourant.Solde;
            Assert.AreEqual(expected, actual, 0.001m, "Account not debited correctly");
        }

        [TestMethod]
        public void Debiter_ShouldThrowArgumentOutOfRange()
        {
            decimal beginningBalance = 1500.50m;
            decimal debitAmount = -3000;

            CompteCourant compteCourant = new(clients[0], DateAleatoire(), beginningBalance);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => compteCourant.Debiter(debitAmount));

        }
    }
}
