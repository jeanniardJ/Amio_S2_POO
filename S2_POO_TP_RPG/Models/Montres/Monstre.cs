using S2_POO_TP_RPG.Models.Personnages;
using System.Numerics;

namespace S2_POO_TP_RPG.Models.Montres
{
    internal abstract class Monstre
    {
        private string nom;

        private int niveau;

        private int pointDeVie;

        private int force;

        private int defense;

        private TypeMonstre type;

        public Monstre(string nom, int niveau, int pointDeVie, int force, int defense, TypeMonstre type)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.pointDeVie = pointDeVie;
            this.force = force;
            this.defense = defense;
            this.type = type;
        }

        public int Attaque(Personnage cible)
        {
            return 0;
        }

        public virtual int CalculerDegats(Personnage cible)
        {
            return 0;
        }

        public virtual int ExperienceDonnee()
        {
            return 0;
        }
    }
}
