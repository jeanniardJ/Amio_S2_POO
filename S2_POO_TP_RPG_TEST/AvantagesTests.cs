using S2_POO_TP_RPG.Models.Personnages;
using S2_POO_TP_RPG.Models.Montres;
using S2_POO_TP_RPG.Models;

namespace S2_POO_TP_RPG_TEST
{
    public class AvantagesTests
    {
        [Fact]
        public void CalculerBonusAttaquant_DoitRetournerUnBonusValide()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");
            Dragon dragon = new("Smaug", 1, 300, 20, 10);

            // Act
            double bonus = Avantages.CalculerBonusAttaquant(guerrier, dragon);

            // Assert
            Assert.True(bonus > 0);
        }
    }
}
