using S2_POO_TP_RPG.Models.Interfaces;

namespace S2_POO_TP_RPG.Models.Personnages
{
    //5 instance de personnage max par le joueur (cpt à chaque personnage de tout type crée)
    //Chaque personnage monte de niveau en accumulant de l’expérience(XP).
    //L'XP est partagée équitablement entre tous les membres vivants de l’équipe à la fin d'un combat.

    internal abstract class Personnage : IAttaquables
    {
        protected string _nom;

        protected int _niveau;

        protected int _experience;

        private int _pointsDeVie;

        private int _force;

        private int _defense; //Coups encaissables

        private bool estEnDefense;

        private int nombreCoupsRestants;

        protected Personnage(string nom, int niveau, int pv, int force, int defense)
        {
            _nom = nom;
            _niveau = niveau;
            _pointsDeVie = pv;
            _force = force;
            _defense = defense;

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
                """;
        }

        //Gagne l'exp partager à la mort d'un monstre
        public virtual void GagnerExperience(int experience)
        {
            _experience += experience;
        }

        public virtual void MonterDeNiveau()
        {
            //_pointDeVie,_force,_defense
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
            //_pointDeVie,_force,_defense
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

        public int ExperiencePourNiveauSuivant()
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
