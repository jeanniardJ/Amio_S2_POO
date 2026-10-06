namespace S2_POO_TP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persA = new Person("DoeA", "John", 32);
            Person persB = new Person("DoeB", "John", 25);
            Person persC = new Person("DoeC", "John", 19);

            Console.WriteLine($"Nombre d'instance de la classe personne : {Person.GetInstance()}");

            Console.WriteLine($"Moyenne d'age des personnes est : {Person.MoyenneAges()}");

            Car audi = new Car("Allemand", "Audi TT", 65487, new DateTime(2023, 10, 5), 211);
            Car renaud = new Car("France", "Renaud 3", 456, new DateTime(2026, 2, 5), 110);

            audi.AddBrand("GA-257-KJ");
            audi.AddBrand("GA-257-KJ");
            audi.AddBrand("GA-263-KJ");
            audi.AddBrand("AB-001-CD");

            renaud.AddBrand("EF-123-GH");
            renaud.AddBrand("IJ-456-KL");

            audi.AddOwner(persA);

            renaud.AddOwner(persB);

            persA.AddCar(audi);
            persA.AddCar(renaud);

            persA.Print();

            audi.Print();

            //renaud.Print();

            //pers.RemoveCar(renaud);

            //pers.Print();
        }
    }
}
