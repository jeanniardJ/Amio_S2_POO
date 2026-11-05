using S2_POO_TP_RPG.Models.Montres;

namespace S2_POO_TP_RPG_TEST
{
    public class DragonTests
    {
        [Fact]
        public void ExperienceDonnee_DoitRetournerCentFoisLeNiveau()
        {
            // Arrange
            Dragon dragon = new("Smaug", 3, 500, 30, 20);

            // Act
            int experience = dragon.ExperienceDonnee();

            // Assert
            Assert.Equal(300, experience);
        }
    }
}