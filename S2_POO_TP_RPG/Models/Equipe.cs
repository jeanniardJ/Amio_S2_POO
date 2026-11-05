using S2_POO_TP_RPG.Models.Personnages;

namespace S2_POO_TP_RPG.Models
{
    internal class Equipe
    {
        //L'equipe doit avoir un personnage pour commencer la partie
        private List<Personnage> personnages = [];

        public override string ToString()
        {
            string CompositionDEquipe = "";

            foreach (var personnage in personnages)
            {
                CompositionDEquipe += $"{personnage.ToString()}";
            }

            return CompositionDEquipe;
        }

        public void AddPerson(Personnage personnage)
        {
            personnages.Add(personnage);
        }

        public int CountPerson()
        {
            return personnages.Count();
        }
    }
}
