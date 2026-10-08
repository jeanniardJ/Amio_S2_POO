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

            Person garagisteA = new Garagiste("Lefèvre", "Thomas", garageA);

            garageA.AddGaragiste(garagisteA);

            Person clientA = new Client("Doe", "John");

            Car voitureA = new Car("AB-123-CD", clientA);
            Car voitureB = new Car("EF-456-GH", clientA);

            clientA.Informations();
            clientA.Print();

            garagisteA.Informations();
            garagisteA.Print();
        }
    }
}
