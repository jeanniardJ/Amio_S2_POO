namespace S2_POO_TP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entreprise garageA = new Garage("Gros Boucher S.A.S", "345 130 488 00017");
            Car voitureA = new();

            Garage.Repeindre(voitureA);

            Console.WriteLine(voitureA.Color);

            garageA.Print();
        }

        
    }
}
