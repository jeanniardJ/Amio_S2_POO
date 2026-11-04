namespace S2_POO_TP_RPG.Models.Personnages
{
    internal class Archer : Personnage
    {
        private int _precision;

        public Archer(string nom, int niveau, int pv, int force, int defense, int precision) : base(nom, niveau, pv, force, defense)
        {
            _precision = precision;
        }

        public override string? ToString()
        {
            return $"\nL'archer :\n{base.ToString()},\n Précision : {_precision}\n";
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
            return false;
        }

        public override void MonterDeNiveau()
        {
            base.MonterDeNiveau();
        }

    }
}
