using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models.Montres
{
    internal class Gobelin : Monstre
    {
        public Gobelin(string nom, int niveau, int pointDeVie, int force, int defense) : base(nom, niveau, pointDeVie, force, defense, TypeMonstre.GOBELIN)
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override int CalculerDegats(Personnage cible)
        {
            return base.CalculerDegats(cible);
        }

        public override int ExperienceDonnee()
        {
            return base.ExperienceDonnee();
        }

    }
}
