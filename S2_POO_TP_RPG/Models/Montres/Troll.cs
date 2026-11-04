using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models.Montres
{
    internal class Troll : Monstre
    {
        public Troll(string nom, int niveau, int pointDeVie, int force, int defense, TypeMonstre type) : base(nom, niveau, pointDeVie, force, defense, type)
        {
        }

        public override int CalculerDegats(Personnage cible)
        {
            return base.CalculerDegats(cible);
        }

        public override int ExperienceDonnee()
        {
            return base.ExperienceDonnee();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
