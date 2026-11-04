using S2_POO_TP_RPG.Models.Interfaces;

namespace S2_POO_TP_RPG.Models.Personnages
{
    internal abstract class Personnage : IAttaquables
    {
        protected string _nom;

        protected int _niveau;

        protected int _experience;

        protected int _pointsDeVie;

        protected int _force;

        protected int _defense;

        private bool estEnDefense;

        private int nombreCoupsRestants;

        public Personnage(string nom, int niveau, int pv, int force, int defense)
        {
            _nom = nom;
            _niveau = niveau;
            _pointsDeVie = pv;
            _force = force;
            _defense = defense;

        }

        public virtual void GagnerExperience(int experience)
        {
            throw new NotImplementedException();
        }

        public virtual void MonterDeNiveau()
        {
            throw new NotImplementedException();
        }

        public virtual int Attaquer(Personnage cible)
        {
            throw new NotImplementedException();
        }

        public virtual void SeDefendre()
        {
            throw new NotImplementedException();
        }

        public virtual void NePlusSedefendre()
        {
            throw new NotImplementedException();
        }

        public void SubirDegats(int degat)
        {
            throw new NotImplementedException();
        }

        public bool EstVivant()
        {
            throw new NotImplementedException();
        }

        public virtual int CalculerDegats(Personnage cible)
        {
            throw new NotImplementedException();
        }

        public int ExperiencePourNiveauSuivatn()
        {
            throw new NotImplementedException();
        }

        public virtual bool PeutSeDefendre()
        {
            throw new NotImplementedException();
        }

        public void ReinitiliserCoupsRestants()
        {
            throw new NotImplementedException();
        }
    }

}
