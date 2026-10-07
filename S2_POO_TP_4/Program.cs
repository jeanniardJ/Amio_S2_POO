namespace S2_POO_TP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entreprise garageA = new Garage("Gros Boucher S.A.S", "345 130 488 00017");
            Entreprise garageB = new Garage("Brun SARL", "872 249 552 00672");

            Person garagisteA = new Garagiste("Lefèvre", "Thomas");

            Client clientA = new Client("Doe", "John");

            Car voitureA = new Car("AB-123-CD", clientA);
            Car voitureB = new Car("EF-456-GH", clientA);

            clientA.AddCar(voitureA);
            clientA.AddCar(voitureB);

            clientA.AfficheCars();

            //Garage.Repeindre(voitureA);

            //Console.WriteLine(voitureA.Color);

            //garageA.Print();
        }


    }
}
