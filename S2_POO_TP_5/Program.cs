namespace S2_POO_TP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //la variable person qui contient un objet Person() est de type Person 
            //Person person = new Person();
            

            Garage garageA = new Garage("Gros Boucher S.A.S", "345 130 488 00017");
            Garage garageB = new Garage("Brun SARL", "872 249 552 00672");

            Garagiste garagisteA = new Garagiste("Lefèvre", "Thomas", garageA);

            garageA.AddGaragiste(garagisteA);

            Person personA = new Client("Doe", "John");
            Person personB = new Client("Bernard", "Lucas");

            Client clientA = new Client(personA);

            Car voitureA = new Car("AB-123-CD", clientA);
            Car voitureB = new Car("EF-456-GH", clientA);

            Truck camionA = new Truck("IJ-789-KL", clientB);

            clientA.Informations();
            clientA.Print();
            Doe.AfficheCars();

            garagisteA.Informations();
            garagisteA.Print();
        }
    }
}
