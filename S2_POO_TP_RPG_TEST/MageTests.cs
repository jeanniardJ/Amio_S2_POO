using S2_POO_TP_RPG.Models.Personnages;
using S2_POO_TP_RPG.Models.Montres;
using S2_POO_TP_RPG.Models.Sorts;

namespace S2_POO_TP_RPG_TEST
{
    public class MageTests
    {
        [Fact]
        public void PeutSeDefendre_DoitRetournerFalse()
        {
            // Arrange
            Mage mage = new("Gandalf", 1, 80, 5, 2, 100);

            // Act
            bool resultat = mage.PeutSeDefendre();

            // Assert
            Assert.False(resultat);
        }

        [Fact]
        public void LancerSort_BouleDeFeu_DoitInfligerDesDegats()
        {
            // Arrange
            Mage mage = new("Gandalf", 1, 80, 5, 2, 100);
            Orc orc = new("Gorg", 1, 100, 10, 2);

            // Act
            int degats = mage.LancerSort(orc, TypeSort.BOULE_DE_FEU);

            // Assert
            Assert.True(degats > 0);
        }

        [Fact]
        public void Affaiblir_DoitAppliquerUnEffetAuMonstre()
        {
            // Arrange
            Mage mage = new("Gandalf", 1, 80, 5, 2, 100);
            Orc orc = new("Gorg", 1, 100, 10, 2);

            // Act
            mage.Affaiblir(orc, 2);

            // Assert
            Assert.True(orc.Effets.Count > 0);
        }
    }
}