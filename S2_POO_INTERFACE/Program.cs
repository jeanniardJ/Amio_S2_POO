namespace S2_POO_INTERFACE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal chien = new Chien();
            chien.FaireDuBruit();
            chien.Manger();

            IAnimal chat = new Chat();
            chat.FaireDuBruit();

            IAnimal oiseau = new Oiseau();

            oiseau.FaireDuBruit();
        }
    }
}
