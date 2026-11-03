using S2_POO_TP_PANIER_DLL;

namespace S2_POO_TP_PANIER_TEST
{
    public class LignePanierTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            Article article = new(1, "Clavier", 50);

            // Act
            LignePanier lignePanier = new(article, 2);

            // Assert
            Assert.Equal(article, lignePanier.Article);
            Assert.Equal(2, lignePanier.Quantite);
        }

        [Fact]
        public void Montant_ShouldReturnQuantityMultipliedByPrice()
        {
            // Arrange
            Article article = new(1, "Clavier", 50);
            LignePanier lignePanier = new(article, 3);

            // Act
            double montant = lignePanier.Montant();

            // Assert
            Assert.Equal(150, montant);
        }

        [Fact]
        public void Montant_ShouldReturnZero_WhenQuantityIsZero()
        {
            // Arrange
            Article article = new(1, "Clavier", 50);
            LignePanier lignePanier = new(article, 0);

            // Act
            double montant = lignePanier.Montant();

            // Assert
            Assert.Equal(0, montant);
        }

        [Fact]
        public void Quantite_ShouldBeModifiable()
        {
            // Arrange
            Article article = new(1, "Clavier", 50);
            LignePanier lignePanier = new(article, 1);

            // Act
            lignePanier.Quantite = 5;

            // Assert
            Assert.Equal(5, lignePanier.Quantite);
        }

        [Fact]
        public void ToString_ShouldReturnExpectedString()
        {
            // Arrange
            Article article = new(1, "Clavier", 50);
            LignePanier lignePanier = new(article, 2);

            // Act
            string result = lignePanier.ToString();

            // Assert
            Assert.Equal(
                "Prix de l'article : 50, référence : 1 et désignation : Clavier, quantité : 2 et le montant est 100",
                result);
        }
    }
}