namespace S2_POO_TP_1;

internal class Program
{
    static void Main(string[] args)
    {
        Person personne = new Person();
        Car audi = new Car();

        personne.Name = "Doe";
        personne.FirstName = "John";
        personne.Age = 32;

        audi.Registration = "France";
        audi.Model = "Audi TT";
        audi.Brand = "AV48CE";
        audi.KLM = 56432;
        audi.OriginalInServiceDate = new DateTime(2023, 10, 5);
        audi.Power = 211;
        audi.Owner = personne;

        personne.Print();

        audi.Print();
    }
}
