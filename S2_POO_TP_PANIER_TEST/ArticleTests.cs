using S2_POO_TP_PANIER_DLL;

namespace S2_POO_TP_PANIER_TEST
{
    public class ArticleTests
    {
        [Fact]
        public void ToString_ShouldReturnExpectedFormat()
        {
            // Arrange
            Article article = new(1, "Clavier", 49.99);

            // Act
            string result = article.ToString();

            // Assert
            Assert.Equal("Prix de l'article : 49.99, référence : 1 et désignation : Clavier", result);
        }

        [Fact]
        public void Equals_ShouldReturnTrue_WhenReferencesAreIdentical()
        {
            // Arrange
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(1, "Souris", 19.99);

            // Act
            bool result = article1.Equals(article2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenReferencesAreDifferent()
        {
            // Arrange
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(2, "Clavier", 49.99);

            // Act
            bool result = article1.Equals(article2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenObjectIsNull()
        {
            // Arrange
            Article article = new(1, "Clavier", 49.99);

            // Act
            bool result = article.Equals(null);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenObjectIsNotArticle()
        {
            // Arrange
            Article article = new(1, "Clavier", 49.99);

            // Act
            bool result = article.Equals("Clavier");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CompareTo_ShouldReturnZero_WhenReferencesAreEqual()
        {
            // Arrange
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(1, "Souris", 19.99);

            // Act
            int result = article1.CompareTo(article2);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CompareTo_ShouldReturnNegativeValue_WhenReferenceIsLower()
        {
            // Arrange
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(2, "Souris", 19.99);

            // Act
            int result = article1.CompareTo(article2);

            // Assert
            Assert.True(result < 0);
        }

        [Fact]
        public void CompareTo_ShouldReturnPositiveValue_WhenReferenceIsGreater()
        {
            // Arrange
            Article article1 = new(2, "Clavier", 49.99);
            Article article2 = new(1, "Souris", 19.99);

            // Act
            int result = article1.CompareTo(article2);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void CompareTo_ShouldReturnOne_WhenOtherIsNull()
        {
            // Arrange
            Article article = new(1, "Clavier", 49.99);

            // Act
            int result = article.CompareTo(null);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetHashCode_ShouldReturnSameValue_ForSameInstance()
        {
            // Arrange
            Article article = new(1, "Clavier", 49.99);

            // Act
            int hash1 = article.GetHashCode();
            int hash2 = article.GetHashCode();

            // Assert
            Assert.Equal(hash1, hash2);
        }

        [Fact]
        public void GetHashCode_ShouldReturnSameValue_ForArticlesWithSameReference()
        {
            // Arrange
            Article article1 = new(1, "Clavier", 49.99);
            Article article2 = new(1, "Souris", 19.99);

            // Act & Assert
            Assert.Equal(article1.GetHashCode(), article2.GetHashCode());
        }
    }
}