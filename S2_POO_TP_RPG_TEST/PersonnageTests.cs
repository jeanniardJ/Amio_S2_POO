using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG_TEST
{
    public class PersonnageTests
    {
        [Fact]
        public void GagnerExperience_DoitAjouterLExperience()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");

            // Act
            guerrier.GagnerExperience(50);

            // Assert
            Assert.Equal(50, guerrier.Experience);
        }

        [Fact]
        public void ExperiencePourNiveauSuivant_DoitRetournerNiveauMultiplieParCent()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 5, 100, 10, 5, "Épée");

            // Act
            int experienceRequise = guerrier.ExperiencePourNiveauSuivant();

            // Assert
            Assert.Equal(500, experienceRequise);
        }

        [Fact]
        public void SubirDegats_DoitDiminuerLesPointsDeVie()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");

            // Act
            guerrier.SubirDegats(20);

            // Assert
            Assert.Equal(80, guerrier.PointsDeVie);
        }

        [Fact]
        public void EstVivant_DoitRetournerFalse_LorsqueLesPvSontAZero()
        {
            // Arrange
            Guerrier guerrier = new("Conan", 1, 100, 10, 5, "Épée");
            guerrier.SubirDegats(100);

            // Act
            bool resultat = guerrier.EstVivant();

            // Assert
            Assert.False(resultat);
        }
    }
}
