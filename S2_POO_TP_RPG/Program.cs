using S2_POO_TP_RPG.Models;
using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG
{
    internal class Program
    {
        //Mode de jeu tour par tour

        static void Main()
        {
            const int NBRPERSO = 5;
            bool exitGame = false;
            int choix;
            ConsoleKeyInfo keyInput;
            Equipe equipe = new();

            //Lancer une partir, creation d'une équipe de 5 perso {Guerrier, Mage, Assassin, Archer, Paladin}.
            //niveau gagnier avec l'xp acumuler pendant la partie et diviser equitablement

            do
            {
                //Demander à l'utilisateur de crée l'equipe de 5 perso, avec un choix donner par la liste 
                //Ou de lui donner la posibiliter de quitter

                //Afficher les personnages que le joueur dois choisir et l'equipe en cours de construction
                while (equipe.CountPerson() < 5)
                {
                    
                    Console.WriteLine($"""
                    Choisir un personnage à inclurer dans l'équipe :
                    1 -> Archer
                    2 -> Assasin
                    3 -> Guerrier
                    4 -> Mage
                    5 -> Paladin
                    q -> Exit
                    """);

                    keyInput = Console.ReadKey();

                    if (int.TryParse(keyInput.KeyChar.ToString(), out choix) && choix is >= 1 and <= 5)
                    {
                        Personnage personnage = choix switch {
                            1 => new Archer("Lyra", 3, 45, 8, 10, 15),
                            2 => new Assassin("Kael", 2, 35, 14, 4),
                            3 => new Guerrier("Thorin", 5, 80, 16, 18, "Épée longue"),
                            4 => new Mage("Elara", 4, 40, 5, 8, 20),
                            5 => new Paladin("Ser Aldric", 4, 70, 12, 15, 12)
                        };   

                        equipe.AddPerson(personnage);
                    } 
                    else
                    {
                        Console.WriteLine("\nLe choix posible est de 1 à 5\n");
                        Thread.Sleep(1000);
                    }
                    
                    Console.Clear();

                    if (equipe.CountPerson() > 0)
                    {
                        Console.WriteLine("Composition de l'équipe :");
                        Console.WriteLine($"{equipe.ToString()}\n");
                    }

                    if (keyInput.KeyChar.ToString().ToLower() == "q")
                    {
                        exitGame = true;
                        break;
                    }
                }

            } while (!exitGame);
        }
    }
}
