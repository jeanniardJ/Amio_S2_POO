using S2_POO_TP_RPG.Models;
using S2_POO_TP_RPG.Models.Personnages;
using S2_POO_TP_RPG.Models.Sorts;

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

                //Une fois que l'equipe est selectionné genere l'equipe de montres 
                //Genere un monstre, puis génere une équipe de monstres plutart
                CreateTeamMonstre();

                //Une fois les équipes faites, lancer la partie tour par tour
                RunGame();

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
                //TODO : Rendre le choix des personnages dynamique
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

                if(IsStartGame && keyInput.KeyChar.ToString().ToLower() == "s")
                {
                    break;
                }

            } while (nbrPersonnageInEquipe < 5);

            Console.Clear();
            Console.WriteLine($"L'équipe est compléte de {nbrPersonnageInEquipe} personne(s).");

        }

        //Creation de l'equipe de monstre en fonction du nombre de personnages créés
        private static void CreateTeamMonstre()
        {
            //
        }

        private static void RunGame()
        {


            //FONCTION TourDeCombat(equipeJoueur, equipeMonstres)
            //    // --- Phase 1 : Réinitialisation des coups encaissables ---
            //    POUR CHAQUE personnage DANS equipeJoueur.Membres
            //        SI personnage.EstVivant()
            //            personnage.ReinitialiserCoupsRestants()
            //    // --- Phase 2 : Choix des actions du joueur ---
            //    POUR CHAQUE personnage DANS equipeJoueur.Membres
            //        SI personnage.EstVivant()
            //            SI personnage.PeutSeDefendre()
            //                AFFICHER "Que fait {personnage.Nom} ? (1: Attaquer / 2: Se défendre)"
            //                choix = LireChoixUtilisateur()
            //                SI choix == 2
            //                    personnage.SeDefendre()
            //                SINON
            //                    // --- Choix de la cible pour l'attaque ---
            //                    AFFICHER "Choisir une cible parmi les monstres :"
            //                    AFFICHER ListeDesMonstresVivants(equipeMonstres)
            //                    choixCible = LireChoixUtilisateur()
            //                    personnage.CibleChoisie = SelectionnerCibleParIndex(equipeMonstres, choixCible)
            //                    personnage.NePlusSeDefendre()
            //            SINON
            //                // --- Choix de la cible pour l'attaque (personnage ne peut pas se défendre) ---
            //                AFFICHER "Choisir une cible parmi les monstres :"
            //                AFFICHER ListeDesMonstresVivants(equipeMonstres)
            //                choixCible = LireChoixUtilisateur()
            //                personnage.CibleChoisie = SelectionnerCibleParIndex(equipeMonstres, choixCible)
            //                personnage.NePlusSeDefendre()
            //                AFFICHER "{personnage.Nom} ne peut pas se défendre et attaquera."
            //    // --- Phase 3 : Attaque des monstres (priorité aux défenseurs) ---
            //    POUR CHAQUE monstre DANS equipeMonstres.Membres
            //        SI monstre.EstVivant()
            //            // Trouver les personnages en défense et vivants
            //            personnagesEnDefense = Filtrer(equipeJoueur.Membres,
            //                p => p.EstVivant() && p.EstEnDefense && p.NombreCoupsRestants > 0)
            //            // Si des défenseurs existent, cibler l'un d'eux
            //            SI personnagesEnDefense.NonVide()
            //                cible = SelectionnerCibleAvecMoinsDeCoupsRestants(personnagesEnDefense)
            //            SINON
            //                // Sinon, cibler un personnage vivant aléatoire
            //                cible = SelectionnerCibleAleatoire(equipeJoueur.Membres, p => p.EstVivant())
            //            SI cible != null
            //                degats = monstre.Attaquer(cible)
            //                cible.SubirDegats(degats)
            //                // Décrémenter le nombre de coups restants pour la cible
            //                cible.NombreCoupsRestants--
            //    // --- Phase 4 : Attaque des personnages ---
            //    POUR CHAQUE personnage DANS equipeJoueur.Membres
            //        SI personnage.EstVivant() ET!personnage.EstEnDefense
            //            // Si le personnage est un Mage, proposer des sorts ou une attaque
            //            SI personnage EST Mage
            //                AFFICHER "Choisir une action : (1: Attaquer / 2: Lancer un sort)"
            //                choix = LireChoixUtilisateur()
            //                SI choix == 1
            //                    // Attaquer la cible choisie précédemment
            //                    degats = personnage.Attaquer(personnage.CibleChoisie)
            //                    personnage.CibleChoisie.SubirDegats(degats)
            //                SINON
            //                    AFFICHER "Quel sort ? (1: Boule de feu / 2: Affaiblir / 3: Bouclier)"
            //                    choixSort = LireChoixUtilisateur()
            //                    SI choixSort == 1
            //                        degats = personnage.LancerSort(personnage.CibleChoisie, TypeSort.BOULE_DE_FEU)
            //                        personnage.CibleChoisie.SubirDegats(degats)
            //                    SINON SI choixSort == 2
            //                        personnage.Affaiblir(personnage.CibleChoisie, 2)
            //                    SINON SI choixSort == 3
            //                        personnage.LancerSort(personnage, TypeSort.BOUCLIER)
            //            SINON
            //                // Attaquer la cible choisie précédemment
            //                degats = personnage.Attaquer(personnage.CibleChoisie)
            //                personnage.CibleChoisie.SubirDegats(degats)
            //    // --- Phase 5 : Gestion de l'XP et des effets ---
            //    // Vérifier si des monstres sont morts et répartir l'XP
            //    xpTotale = 0
            //    POUR CHAQUE monstre DANS equipeMonstres.Membres
            //        SI !monstre.EstVivant() ET monstre.EstMarqueCommeMortDansCeTour()
            //            xpTotale += monstre.ExperienceDonnee()
            //            monstre.MarquerCommeNonMortDansCeTour()
            //    SI xpTotale > 0
            //        nombreVivants = CompterVivants(equipeJoueur)
            //        xpParPersonnage = xpTotale / nombreVivants
            //        POUR CHAQUE personnage DANS equipeJoueur.Membres
            //            SI personnage.EstVivant()
            //                personnage.GagnerExperience(xpParPersonnage)
            //    // Appliquer les effets temporaires (exemple: Affaiblir, Bouclier)
            //    POUR CHAQUE personnage DANS equipeJoueur.Membres + equipeMonstres.Membres
            //        SI personnage.ADesEffets()
            //            POUR CHAQUE effet DANS personnage.Effets
            //                effet.Appliquer()
            //                effet.DecrementerDuree()
            //                SI effet.Duree == 0
            //                    SupprimerEffet(personnage, effet)
            //FIN FONCTION
        }
    }
}
