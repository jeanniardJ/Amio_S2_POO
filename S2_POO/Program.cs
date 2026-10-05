namespace S2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exemple découverte d'objet
            Rectangle rect = new Rectangle();

            rect.hauteur = 25;
            rect.largeur = 60;

            rect.affiche(25, 60, rect.surface(25, 60));

            Cercle c1;
            //Console.WriteLine(c1.Rayon);

            //A
            A a1, a2;
            a1 = new A();
            A a3 = a1;
            A a4 = new A();

            //Pseronne

            Personne p1 = new Personne();
            p1.Nom = "UN";
            Personne p2 = p1;
            p2.Nom = "DEUX";
            Console.WriteLine(p1.Nom);

            //
            int n1 = 3;
            int n2 = 2;
            float resultat = n1 / n2;
        }
    }
}
