using S2_POO_TP_PANIER_DLL;

namespace S2_POO_TP_PANIER_TEST
{
    public class PanierTests
    {
        [Fact]
        public void NouveauPanier_TotalDoitEtreZero()
        {
            // Arrange
            Panier panier = new();

            // Act
            double total = panier.Total();

            // Assert
            Assert.Equal(0, total);
        }

        [Fact]
        public void AjouterArticle_SansQuantite_DoitAjouterUneUnite()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            // Act
            panier.AjouterArticle(article);

            // Assert
            Assert.Equal(50, panier.Total());
        }

        [Fact]
        public void AjouterArticle_AvecQuantite_DoitMettreAJourLeTotal()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            // Act
            panier.AjouterArticle(article, 3);

            // Assert
            Assert.Equal(150, panier.Total());
        }

        [Fact]
        public void AjouterDeuxArticlesDifferents_DoitCalculerLeBonTotal()
        {
            // Arrange
            Panier panier = new();
            Article article1 = new(1, "Clavier", 50);
            Article article2 = new(2, "Souris", 20);

            // Act
            panier.AjouterArticle(article1, 2);
            panier.AjouterArticle(article2, 3);

            // Assert
            Assert.Equal(160, panier.Total());
        }

        [Fact]
        public void AjouterDeuxFoisLeMemeArticle_DoitCumulerLesQuantites()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            // Act
            panier.AjouterArticle(article, 2);
            panier.AjouterArticle(article, 3);

            // Assert
            Assert.Equal(250, panier.Total());
        }

        [Fact]
        public void Vider_DoitRemettreLeTotalAZero()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            panier.AjouterArticle(article, 3);

            // Act
            panier.Vider();

            // Assert
            Assert.Equal(0, panier.Total());
        }

        [Fact]
        public void SupprimerArticle_DoitRetirerLArticleDuPanier()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            panier.AjouterArticle(article, 2);

            // Act
            panier.SupprimerArticle(article);

            // Assert
            Assert.Equal(0, panier.Total());
        }

        [Fact]
        public void SupprimerArticle_Absent_NeDoitPasLeverException()
        {
            // Arrange
            Panier panier = new();
            Article article = new(1, "Clavier", 50);

            // Act
            Exception? exception = Record.Exception(() =>
                panier.SupprimerArticle(article));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void AjouterPuisSupprimerUnArticle_DoitConserverLesAutresArticles()
        {
            // Arrange
            Panier panier = new();

            Article article1 = new(1, "Clavier", 50);
            Article article2 = new(2, "Souris", 20);

            panier.AjouterArticle(article1, 2);
            panier.AjouterArticle(article2, 3);

            // Act
            panier.SupprimerArticle(article1);

            // Assert
            Assert.Equal(60, panier.Total());
        }

        [Fact]
        public void Afficher_NeDoitPasLeverException()
        {
            // Arrange
            Panier panier = new();

            panier.AjouterArticle(
                new Article(1, "Clavier", 50),
                2);

            // Act
            Exception? exception = Record.Exception(() =>
                panier.Afficher());

            // Assert
            Assert.Null(exception);
        }
    }
}
