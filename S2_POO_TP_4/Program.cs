namespace S2_POO_TP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garageA = new Garage("Gros Boucher S.A.S", "345 130 488 00017");
            Garage garageB = new Garage("Brun SARL", "872 249 552 00672");

            Garagiste garagisteA = new Garagiste("Lefèvre", "Thomas");

            garageA.AddGaragiste(garagisteA);

            Client clientA = new Client("Doe", "John");

            Car voitureA = new Car("AB-123-CD", clientA);
            Car voitureB = new Car("EF-456-GH", clientA);

            clientA.AddCar(voitureA);
            clientA.AddCar(voitureB);

            clientA.AfficheCars();

            clientA.DropOffCar(garageA, voitureA);

            clientA.AfficheCars();

            //Affiche la liste des voitures en attentes de reparation ou de d'être récuperer
            garageA.AfficheCars();

            //Garage.Repeindre(voitureA);

            //Console.WriteLine(voitureA.Color);

            //garageA.Print();
        }


    }
}
