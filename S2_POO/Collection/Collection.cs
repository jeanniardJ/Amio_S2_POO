using S2_POO.Alphabet;

namespace S2_POO.Collection
{
    internal static class Collection
    {
        public static void STestList()
        {
            //List qui contient des entiers
            List<string> strings = [];

            strings.Add("1e");
            strings.Add("2");
            strings.Add("3");
            strings.Add("4");
            strings.Add("5");
            strings.Add("2");

            unsafe
            {
                for (int i = 0; i < strings.Count; i++)
                {

                    fixed (char* str = strings[i])
                    {
                        Console.WriteLine($"0x{(nuint)str:X}");

                        char* nextChar = str + 8100000;


                        Console.WriteLine(*nextChar);

                    }
              
                }
            }

        }

        public static void STestDictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 30;
            ages["Bob"] = 25;
            Console.WriteLine(ages["Alice"]); // Affiche 30
        }

        /// <summary>
        /// Demonstrates basic queue operations by enqueuing and dequeuing string elements.
        /// </summary>
        public static void STestQueue()
        {
            Queue<string> file = new Queue<string>();
            file.Enqueue("Premier");
            file.Enqueue("Deuxième");
            Console.WriteLine(file.Dequeue()); // Affiche "Premier"
        }

        /// <summary>
        /// Demonstrates basic stack operations by pushing and popping string elements.
        /// </summary>
        public static void STestStack()
        {
            Stack<string> pile = new Stack<string>();
            pile.Push("Premier");
            pile.Push("Deuxième");
            Console.WriteLine(pile.Pop()); // Affiche "Deuxième"
        }

        /// <summary>
        /// Demonstrates adding elements to a HashSet and outputs the count of unique elements.
        /// </summary>
        public static void STestHashSet()
        {
            HashSet<int> ensemble = new HashSet<int>();
            ensemble.Add(1);
            ensemble.Add(2);
            ensemble.Add(2); // Ignoré car 2 est déjà présent
            Console.WriteLine(ensemble.Count); // Affiche 2
        }

        public static void STestListAB()
        {
            List<A> maListe = new List<A>();
            A a = new B();
            maListe.Add(new B());
            maListe.Add(new Object());
            maListe.Add(a);

        }
    }
}
