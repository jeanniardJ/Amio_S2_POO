using S2_POO_TP_RPG.Models.Interfaces;

namespace S2_POO_TP_RPG.Models.Personnages
{
    internal class Assassin : Personnage, IDefendable
    {
        private double _chanceCritique;

        public Assassin(string nom, int niveau, int pv, int force, int defense) : base(nom, niveau, pv, force, defense)
        {
        }

        public override string? ToString()
        {
            return $"\nL'assassin :\n{base.ToString()},\n Chance de coûts critique : {_chanceCritique}\n";
        }

        public override int Attaquer(Personnage cible)
        {
            return base.Attaquer(cible);
        }

        public override int CalculerDegats(Personnage cible)
        {
            return base.CalculerDegats(cible);
        }
        public override bool PeutSeDefendre()
        {
            return base.PeutSeDefendre();
        }

        public override void MonterDeNiveau()
        {
            base.MonterDeNiveau();
        }

    }
}
