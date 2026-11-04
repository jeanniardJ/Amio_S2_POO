using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models.Interfaces
{
    internal interface IAttaquables
    {
        public int Attaquer(Personnage cible);

        public int CalculerDegats(Personnage cible);
    }
}
