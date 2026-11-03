namespace S2_POO_TP_RPG
{
    internal abstract class Personnage
    {
        private string nom;

        private int niveau;

        private int experience;

        private int pointsDeVie;

        private int force;

        private int defense;

        private bool estEnDefense;

        private int nombreCoupsRestants;

        public Personnage(string nom, int niveau, int pv, int force, int defense)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointsDeVie = pv;
            this.force = force;
            this.defense = defense;
        }

        public void GagnerExperience(int experience)
        {

        }

        public void MonterDeNiveau()
        {

        }

        public int Attaquer(Personnage cible)
        {
            return 0;
        }

        public void SeDefendre()
        {

        }

        public void NePlusSeDefendre()
        {

        }

        public void SubirDegats(int degat)
        {

        }

        public bool EstVivant()
        {
            return true;
        }

        public int CalculerDegats(Personnage cible)
        {
            return 1;
        }
    }

}
