namespace S2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect = new Rectangle();

            rect.hauteur = 25;
            rect.largeur = 60;


            rect.affiche(25, 60, rect.surface(25, 60));
        }
    }
}
