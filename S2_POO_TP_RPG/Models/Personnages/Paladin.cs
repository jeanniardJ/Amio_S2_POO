using S2_POO_TP_RPG.Models.Interfaces;

namespace S2_POO_TP_RPG.Models.Personnages
{
    internal class Paladin : Personnage, IDefendable
    {
        private int _foi;
        public Paladin(string nom, int niveau, int pv, int force, int defense, int foi) : base(nom, niveau, pv, force, defense)
        {
            _foi = foi;
        }

        public override string? ToString()
        {
            return $"\nLe Paladin :\n{base.ToString()},\n Foi : {_foi}\n";
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
