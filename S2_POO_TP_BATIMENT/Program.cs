namespace S2_POO_TP_BATIMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new("3 rue des Fleurs, 12100 Millau");

            building.ToString();

            House house = new("5 rue des Marmottes, 23500 Lyon", 3);

            house.ToString();

        }
    }
}
