namespace S2_POO_TP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garageA = new Garage("Gros Boucher S.A.S", "345 130 488 00017");
            Garage garageB = new Garage("Brun SARL", "872 249 552 00672");

            Console.WriteLine("Liste de garagistes : \n");
            Garagiste garagisteA = new Garagiste("Lefèvre", "Thomas", garageA);

            garagisteA.Print();

            garageA.AddGaragiste(garagisteA);

            Console.WriteLine("\nListe de clients : \n");

            Client personA = new Client("Doe", "John");
            Client personB = new Client("Bernard", "Lucas");

            //Quand crée un véhicule, on l'associe à une person
            Car voitureA = new Car("AB-123-CD", personA);
            Car voitureB = new Car("EF-456-GH", personA);
            Truck camionA = new Truck("IJ-789-KL", personA);

            Truck camionB = new Truck("MN-012-OP", personB);
            Truck camionC = new Truck("QR-345-ST", personB);

            Console.WriteLine($"Le(s) véhicule(s) de {personA.Firstname} {personA.Name} sont :");

            foreach (var item in personA.GetVehiclesByOwner())
            {
                Console.WriteLine($"Mon véhicule est de type : {item.GetType().Name}");
                Console.WriteLine($"Dommage de mon véhicule : {item.Dommage}");
                Console.WriteLine($"Immatricule : {item.Immatricul}");
            }

            Console.WriteLine($"\nLe(s) véhicule(s) de {personB.Firstname} {personB.Name} sont :");

            foreach (var item in personB.GetVehiclesByOwner())
            {
                Console.WriteLine($"Mon véhicule est de type : {item.GetType().Name}");
                Console.WriteLine($"Dommage de mon véhicule : {item.Dommage}");
                Console.WriteLine($"Immatricule : {item.Immatricul}");
            }

            //Il faut gere le transfere de l'objet véhicule du client, au garage qui l'assigne au garagiste
            //Le client depose un véhicule à réparer au garage, puis l'assigne à un garagiste.
            //Le garage doit pouvoir renvoier la liste de véhicule 
        }
    }
}
