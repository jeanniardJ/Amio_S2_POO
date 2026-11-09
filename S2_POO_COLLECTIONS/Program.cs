namespace S2_POO_COLLECTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new("Renault", "Mégane", 2022);
            Voiture v2 = new("Peugeot", "308", 2020, 45000);
            Voiture v3 = new("Tesla", "Model 3", 2023);
            Voiture v4 = new("BMW", "Série 3", 2021, 12000);
            Voiture v5 = new("Citroën", "C5", 2019, 78000);
            Voiture v6 = new("Dacia", "Duster", 2024);
            Voiture v7 = new("Audi", "A4", 2022, 23000);
            Voiture v8 = new("Fiat", "500", 2021, 15000);
            Voiture v9 = new("Hyundai", "Tucson", 2023, 8000);
            Voiture v10 = new("Volkswagen", "Golf", 2020, 52000);

            Personne p1 = new("Alice", "Dupont", 30);
            Personne p2 = new("Lucas", "Martin", 35);
            Personne p3 = new("Emma", "Bernard", 22);
            Personne p4 = new("Hugo", "Petit", 28);
            Personne p5 = new("Chloé", "Moreau", 41);
            Personne p6 = new("Nina", "Lefebvre", 19);
            Personne p7 = new("Thomas", "Girard", 45);
            Personne p8 = new("Sophie", "Roux", 33);
            Personne p9 = new("Maxime", "Fournier", 27);
            Personne p10 = new("Léa", "Mercier", 24);

            Dictionary<Voiture, Personne> conducteurs = new()
            {
                { v1,  p1  },
                { v3,  p2  },
                { v2,  p3  },
                { v5,  p4  },
                { v7,  p5  },
                { v4,  p6  },
                { v9,  p7  },
                { v6,  p8  },
                { v10, p9  },
                { v8,  p10 },
            };

            foreach (var entry in conducteurs)
            {
                Console.WriteLine($"{entry.Key.Description()} -> {entry.Value.SePresenter()}");
            }

            Console.WriteLine($"\n--- Accès direct ---");
            Console.WriteLine(conducteurs[v4].SePresenter());
            Console.WriteLine(conducteurs[v4].ToString());
        }
    }
}
