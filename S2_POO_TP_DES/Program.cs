namespace S2_POO_TP_DES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Deux dés (deux instances d'une classe dé), de 6 faces
            De deA = new();
            De deB = new();

            Console.WriteLine($"Resultat du premiere dé {deA.Lancer()}, resultat du second dé {deB.Lancer()}");

            deA.Print();
            deB.Print();
        }
    }
}
