using S2_POO_TP_RPG.Models.Montres;

namespace S2_POO_TP_RPG_TEST
{
    public class GobelinTests
    {
        [Fact]
        public void ExperienceDonnee_DoitRetournerCinquanteFoisLeNiveau()
        {
            // Arrange
            Gobelin gobelin = new("Gob", 2, 50, 5, 2);

            // Act
            int experience = gobelin.ExperienceDonnee();

            // Assert
            Assert.Equal(100, experience);
        }
    }
}
