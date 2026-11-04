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
            return $"""
                Type : {GetType().Name}
                Nom : {_nom},
                Niveau : {_niveau},
                Points de vie : {_pointsDeVie},
                Force : {_force},
                Défence : {_defense}
                Précision : {_precision}
                """;
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
