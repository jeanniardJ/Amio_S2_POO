namespace S2_POO_TP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            Car audi = new Car();

            pers.Name = "Doe";
            pers.FirstName = "John";
            pers.Age = 32;

            audi.Registration = "France";
            audi.Model = "Audi TT";
            audi.Brand = "AV48CE";
            audi.KLM = 56432;
            audi.OriginalInServiceDate = new DateTime(2023, 10, 5);
            audi.Power = 211;
            audi.owner = pers;

            pers.Print();

            audi.Print();
        }
    }
}
