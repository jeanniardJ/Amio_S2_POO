using S2_POO_TP_1;

namespace S2_POO_TP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            Car audi = new Car();
            Car renaud = new Car();

            pers.SetName("Doe");
            pers.SetFirstName("John");
            pers.SetAge(32);

            audi.SetRegistration("Allemand");
            audi.SetModel("Audi TT");
            audi.SetBrand("AV48CE");
            audi.SetKLM(56432);
            audi.SetOriginalInServiceDate(new DateTime(2023, 10, 5));
            audi.SetPower(211);

            audi.AddOwner(pers);

            renaud.SetRegistration("France");
            renaud.SetModel("Renaud 3");
            renaud.SetBrand("AV49CE");
            renaud.SetKLM(564);
            renaud.SetOriginalInServiceDate(new DateTime(2026, 2, 5));
            renaud.SetPower(110);

            renaud.AddOwner(pers);

            pers.AddCar(audi);
            pers.AddCar(renaud);

            pers.Print();

            audi.Print();

            renaud.Print();

            pers.RemoveCar(renaud);

            pers.Print();
        }
    }
}
