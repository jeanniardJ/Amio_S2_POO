using S2_POO_TP_RPG.Models.Montres;
using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models
{
    internal static class Avantages
    {
        public static Dictionary<TypeMonstre, double> Montres;
        public static Dictionary<TypePersonnage, double> Personnages;

        public static double CalculerBonusAttaquant(Personnage attaquant, Personnage cible)
        {
            throw new NotImplementedException();
        }
    }
}
