using S2_POO_TP_RPG.Models.Interfaces;

namespace S2_POO_TP_RPG.Models.Personnages
{
    internal class Guerrier : Personnage, IDefendable
    {
        private string _arme;

        public Guerrier(string nom, int niveau, int pv, int force, int defense, string arme) : base(nom, niveau, pv, force, defense)
        {
            _arme = arme;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override int Attaquer(Personnage cible)
        {
            return base.Attaquer(cible);
        }

        public override int CalculerDegats(Personnage cible)
        {
            return base.CalculerDegats(cible);
        }

        public override void MonterDeNiveau()
        {
            base.MonterDeNiveau();
        }
    }
}
