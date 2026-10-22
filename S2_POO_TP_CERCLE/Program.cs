//TODO: Rajouter une vérification des saisies  en utilisant SaisieDouble par exemple 
//et REVOIR le program maintenant.
namespace S2_POO_TP_CERCLE;

internal class Program
{
    /// <summary>
    /// Permet la saisie d'un double dans la console avec un message en paramètre de manière sécurisée
    /// </summary>
    /// <param name="message">Message de saisie</param>
    /// <returns>Retourne la valeur du double saisie</returns>
    static double SaisieDouble(string message)
    {
        double value = 0;
        bool saisieValide = false;

        do
        {
            Console.WriteLine(message);
            string? inputUser = Console.ReadLine();

            saisieValide = double.TryParse(inputUser, out value);

            if (!saisieValide)
            {
                Console.WriteLine("Erreur de saisie");
            }

        } while (!saisieValide);

        return value;
    }

    static void Main(string[] args)
    {
        double abscisseCercle, ordonneCercle, rayonCercle, abscissePoint, ordonnePoint;

        abscisseCercle = SaisieDouble("Donner l'abscisse du centre: ");
        ordonneCercle = SaisieDouble("Donner l'ordonné du centre: ");
        rayonCercle = SaisieDouble("Donner le rayon: ");

        Cercle cercleA = new(new(abscisseCercle, ordonneCercle), rayonCercle);

        Console.WriteLine(cercleA.Affiche());
        Console.WriteLine($"Le périmétre est : {cercleA.GetPerimetre()}");
        Console.WriteLine($"La surface est : {cercleA.GetSurface()}");

        Console.Write("Donner un point :");

        abscissePoint = SaisieDouble("\nx: ");
        ordonnePoint = SaisieDouble("y: ");

        Point ptA = new(abscissePoint, ordonnePoint);

        Console.WriteLine(ptA.Afficher());

        Console.WriteLine($"Le point {(cercleA.Appartient(ptA) ? "appartient" : "n'appartient pas")} au cercle.");
    }
}
