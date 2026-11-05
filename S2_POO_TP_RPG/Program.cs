using S2_POO_TP_RPG.Models;
using S2_POO_TP_RPG.Models.Montres;
using S2_POO_TP_RPG.Models.Personnages;
using static System.Net.Mime.MediaTypeNames;

namespace S2_POO_TP_RPG
{
    internal class Program
    {


        //Mode de jeu tour par tour

        //TODO : Pour chaque personnage, le joueur choisit entre attaquer ou se défendre (si possible).

        //TODO : Le joueur sélectionne manuellement la cible pour chaque attaque.
        //Afficher le nombre de monstre qui reste au joueur

        //XP gagnier : Quand un monstre meurt, l’XP est partagée entre tous les membres vivants de l’équipe.
        //Chaque personnage monte de niveau en accumulant de l’expérience(XP).
        //L'XP est partagée équitablement entre tous les membres vivants de l’équipe à la fin d'un combat.

        //FIN du combat : Le combat se termine quand tous les personnages ou tous les monstres sont vaincus.

        static void Main()
        {
            //minimun 1 perso dans l'equipe, jusqu'a 5 posible
            bool exitGame = false;
            ConsoleKeyInfo keyInput;

            //Lancer une partir, creation d'une équipe de 5 perso {Guerrier, Mage, Assassin, Archer, Paladin}.
            //niveau gagnier avec l'xp acumuler pendant la partie et diviser equitablement

            do
            {
                //Demander à l'utilisateur de crée l'equipe de x perso (minimum 1 perso), avec un choix donner par la liste 
                //Ou de lui donner la posibiliter de quitter ou la possibiliter de lancer la partie avec un perso.

                //Afficher les personnages que le joueur dois choisir et l'equipe en cours de construction

                ChoixEquipePersonnage();


                keyInput = Console.ReadKey();

                if (keyInput.KeyChar.ToString().ToLower() == "q")
                {
                    break;
                }

                //Pour lancer la partie, il faut aussi une équipe de montres

            } while (!exitGame);
        }

        private static void AffichageCommande(string? menu = null)
        {
            Console.WriteLine($"""
                    {menu}
                        q -> Exit
                    """);
        }

        /// <summary>
        /// Selects and adds a character to the team based on the user's key input.
        /// </summary>
        /// <param name="keyInput">The key input representing the user's character selection.</param>
        private static void ChoixEquipePersonnage()
        {
            int choix;
            bool IsStartGame = false;
            Equipe Equipe = new();
            int nbrPersonnageInEquipe = 0;
            
            ConsoleKeyInfo keyInput;

            //Tant que le joueur n'a pas selectionner 5 personnages ou start le jeux avec au moins 1 personnage
            do
            {
                
                AffichageCommande($"""
                    Choisir un personnage à inclurer dans l'équipe :
                        1 -> Archer
                        2 -> Assasin
                        3 -> Guerrier
                        4 -> Mage
                        5 -> Paladin
                        {(IsStartGame ? "\n    S -> Start" : "")}
                    """);

                keyInput = Console.ReadKey();

                
                if (int.TryParse(keyInput.KeyChar.ToString(), out choix) && choix is >= 1 and <= 5)
                {
                    Personnage personnage = choix switch
                    {
                        1 => new Archer("Lyra", 3, 45, 8, 10, 15),
                        2 => new Assassin("Kael", 2, 35, 14, 4),
                        3 => new Guerrier("Thorin", 5, 80, 16, 18, "Épée longue"),
                        4 => new Mage("Elara", 4, 40, 5, 8, 20),
                        5 => new Paladin("Ser Aldric", 4, 70, 12, 15, 12)
                    };

                    Equipe.AddPerson(personnage);
                    nbrPersonnageInEquipe = Equipe.CountPerson();
                }
                else if(keyInput.KeyChar.ToString().ToLower() != "s")
                {
                    Console.Clear();
                    Console.WriteLine("\nLe choix possible est de 1 à 5 ou 's' pour démarrer la partie!\n");
                    Thread.Sleep(1000);
                }

                Console.Clear();

                

                if (nbrPersonnageInEquipe > 0)
                {
                    Console.WriteLine("Composition de l'équipe :");
                    Console.WriteLine($"{Equipe.ToString()}\n");

                    //Rendre possible de démarrer la partie
                    IsStartGame = true;
                }

                

            } while (nbrPersonnageInEquipe < 5 || (IsStartGame && keyInput.KeyChar.ToString().ToLower() == "s"));

            Console.Clear();
            Console.WriteLine($"L'équipe est compléte de {nbrPersonnageInEquipe} personne(s).");

        }

        //Creation de l'equipe de monstre en fonction du nombre de personnages créés
        private void CreateTeamMonstre()
        {

        }
    }
}
