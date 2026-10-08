namespace S2_POO_POLYMORPH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal Ianimal = new Animal();

            Ianimal.FaireDuBruit();
            Ianimal = new Chat();
            Ianimal.FaireDuBruit();
            Ianimal = new Chien();
            Ianimal.FaireDuBruit();

            Animal animal = new();
            Animal chat = new Chat();
            Animal chien = new Chien();

            animal.FaireDuBruit();
            chat.FaireDuBruit();
            chien.FaireDuBruit();

        }
    }
}
