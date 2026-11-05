using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG_TEST
{
    public class GuerrierTests
    {
        [Fact]
        public void PeutSeDefendre_DoitRetournerTrue()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");

            // Act
            bool resultat = guerrier.PeutSeDefendre();

            // Assert
            Assert.True(resultat);
        }

        [Fact]
        public void SeDefendre_DoitActiverLeModeDefense()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");

            // Act
            guerrier.SeDefendre();

            // Assert
            Assert.True(guerrier.EstEnDefense);
        }

        [Fact]
        public void NePlusSeDefendre_DoitDesactiverLeModeDefense()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");
            guerrier.SeDefendre();

            // Act
            guerrier.NePlusSeDefendre();

            // Assert
            Assert.False(guerrier.EstEnDefense);
        }

        [Fact]
        public void Attaquer_DoitInfligerDesDegats()
        {
            // Arrange
            Guerrier attaquant = new("Conan", 1, 100, 10, 5, "Épée");
            Orc cible = new("Gorg", 1, 100, 8, 2);

            // Act
            int degats = attaquant.Attaquer(cible);

            // Assert
            Assert.True(degats > 0);
        }
    }