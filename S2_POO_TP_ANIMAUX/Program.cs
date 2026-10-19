namespace S2_POO_TP_ANIMAUX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = [
                new Vache("Belle", "Blanc", 450.0),
                new Vache("Milka", "Noir", 520.0),
                new Vache("Rouge", "Roux", 380.0),
                new Vache("Daisy", "Moucheté", 600.0),
                new Vache("Zouzou", "Blanc", 410.0),
                new Chien("Rex", "Brun", 28.5),
                new Chien("Bella", "Blanc", 12.3),
                new Chien("Nala", "Noir", 35.0),
                new Chien("Max", "Beige", 42.7),
                new Chien("Luna", "Gris", 8.2),
                new Chien("Simba", "Rouge", 55.0),
                new Chat("Félix", "Roux", 4.2),
                new Chat("Minou", "Gris", 3.8),
                new Chat("Siamois", "Crème", 5.1),
                new Chat("Néko", "Noir", 4.5),
                new Chat("Perle", "Blanc", 3.2),
                new Chat("Moustache","Brun", 5.8),
                ];


            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
