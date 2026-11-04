using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models.Effets
{
    internal class Effet
    {
        private Personnage cible;

        private int Duree;

        private TypeEffet TypeEffet;

        private int Valeur;

        public Effet(Personnage cible, int duree, TypeEffet typeEffet, int valeur)
        {
            this.cible = cible;
            Duree = duree;
            TypeEffet = typeEffet;
            Valeur = valeur;
        }

        public void Appliquer()
        {

        }

        public void DecrementerDuree()
        {

        }
    }
}
