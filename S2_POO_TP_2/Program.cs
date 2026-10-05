using S2_POO_TP_1;

namespace S2_POO_TP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            Car audi = new Car();

            pers.SetName("Doe");
            pers.SetFirstName("John");
            pers.SetAge(32);

            audi.SetRegistration("France");
            audi.SetModel("Audi TT");
            audi.SetBrand("AV48CE");
            audi.SetKLM(56432);
            audi.SetOriginalInServiceDate(new DateTime(2023, 10, 5));
            audi.SetPower(211);
            audi.AddOwner(pers);

            pers.Print();

            audi.Print();
        }
    }
}
