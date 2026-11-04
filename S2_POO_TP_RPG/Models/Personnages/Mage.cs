using S2_POO_TP_RPG.Models.Interfaces;
using S2_POO_TP_RPG.Models.Montres;

namespace S2_POO_TP_RPG.Models.Personnages
{
    internal class Mage : Personnage
    {
        private int _mana;

        public Mage(string nom, int niveau, int pv, int force, int defense, int mana) : base(nom, niveau, pv, force, defense)
        {
            _mana = mana;
        }

        public override string? ToString()
        {
            return $"\nLe mage :\n{base.ToString()},\n Mana : {_mana}\n";
        }

        public override int Attaquer(Personnage cible)
        {
            return base.Attaquer(cible);
        }

        public int LancerSort(Personnage cible)
        {
            throw new NotImplementedException();
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

        public void Affaiblir(Monstre cible, int duree)
        {
            throw new NotImplementedException();
        }
    }
}
