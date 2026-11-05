using S2_POO_TP_RPG.Models.Personnages;
using S2_POO_TP_RPG.Models.Montres;

namespace S2_POO_TP_RPG_TEST
{
    public class AssassinTests
    {
        [Fact]
        public void PeutSeDefendre_DoitRetournerTrue()
        {
            // Arrange
            Assassin assassin = new("Ezio", 1, 90, 12, 3);

            // Act
            bool resultat = assassin.PeutSeDefendre();

            // Assert
            Assert.True(resultat);
        }

        [Fact]
        public void Attaquer_DoitRetournerDesDegats()
        {
            // Arrange
            Assassin assassin = new("Ezio", 5, 90, 12, 3);
            Gobelin gobelin = new("Gob", 1, 50, 5, 2);

            // Act
            int degats = assassin.Attaquer(gobelin);

            // Assert
            Assert.True(degats > 0);
        }
    }
}
