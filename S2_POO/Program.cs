using S2_POO.Animals;
using S2_POO.Geo_02;
using S2_POO.Alphabet;

namespace S2_POO
{
    internal class Program
    {
        private static int x = 10;
        static void Main(string[] args)
        {
            //Console.WriteLine(x);

            ////exemple découverte d'objet
            //Rectangle rect = new Rectangle();

            //rect.hauteur = 25;
            //rect.largeur = 60;

            //rect.affiche(25, 60, rect.surface(25, 60));

            //Cercle c1 = new Cercle();
            //Console.WriteLine(c1.GetRayon());
            //Console.WriteLine(c1.GetRayon());
            //Console.WriteLine(c1.GetRayon("Bonjour"));

            ////A
            //A a1, a2;
            //a1 = new A();
            //A a3 = a1;
            //A a4 = new A();

            ////Pseronne

            //Personne p1 = new Personne();
            //p1.Nom = "UN";
            //Personne p2 = p1;
            //p2.Nom = "DEUX";
            //Console.WriteLine(p1.Nom);

            ////
            //int n1 = 3;
            //int n2 = 2;
            //float resultat = n1 / n2;

            ////A
            //A a = new();

            //a.Print();

            //Object o1 = new object();
            //Console.WriteLine(o1);

            //A a = new A();
            //B b = new B();

            //b = (B)a;

            //Ceci ne peu pas etre instancier sur à sa spécificiter de classe abstraite
            //Animal animal = new();
            //Chien chienA = new(); //chien est de type Chien
            //Animal chienB = new Chien();//chien est de type qui descend d'animal, chien est de type animal du à l'heritage

            //chienA.FaireDuBruit();
            //chienB.FaireDuBruit();


            //Forme rectangle = new Rectangle(5.5, 6.8);//Type forme, pour objet Rectangle
            //Forme cercle = new Cercle(5.3);

            //Console.WriteLine($"Le rectangle à pour aire : {rectangle.CalculerAire()}");
            //Console.WriteLine($"Le cercle à pour aire : {cercle.CalculerAire()}");

            A b = new B();

            
        }

    }
}
