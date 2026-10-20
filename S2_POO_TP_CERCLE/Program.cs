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
            if (inputUser == null)
            {
                Console.WriteLine("Erreur de saisie");
            }

            try
            {
                value = double.Parse(inputUser);

                saisieValide = true;
            }
            catch (Exception ex)
            {

                saisieValide = false;
                Console.WriteLine("Erreur de saisie");
            }

        } while (!saisieValide);

        return value;
    }

    static void Main(string[] args)
    {
        double abscCercle, ordonCercle, rayonCercle, absPoint, ordonPoint;
        

        Console.Write("Donner l'abscisse du centre: ");
        double.TryParse(Console.ReadLine(), out abscCercle);
        Console.Write("Donner l'ordonné du centre: ");
        double.TryParse(Console.ReadLine(), out ordonCercle);
        Console.Write("Donner le rayon: ");
        double.TryParse(Console.ReadLine(), out rayonCercle);

        Cercle cercleA = new(new(abscCercle, ordonCercle), rayonCercle);

        cercleA.Affiche();
        cercleA.GetPerimetre();
        cercleA.GetSurface();

        Console.Write("Donner un point :");
        Console.Write("\nx: ");
        double.TryParse(Console.ReadLine(), out absPoint);
        Console.Write("y: ");
        double.TryParse(Console.ReadLine(), out ordonPoint);

        Point ptA = new(absPoint,ordonPoint);

        ptA.Afficher();

        //Console.WriteLine(cercleA.Appartient(ptA));

        Console.WriteLine($"Le point {(cercleA.Appartient(ptA) ? "appartient" : "n'appartient pas")} au cercle.");
    }
}
