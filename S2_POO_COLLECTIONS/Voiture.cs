namespace S2_POO_COLLECTIONS
{
    internal class Voiture(string marque, string modele, int annee, int kilometrage = 0)
    {
        public string Marque { get; set; } = marque;
        public string Modele { get; set; } = modele;
        public int Annee { get; set; } = annee;
        public int Kilometrage { get; set; } = kilometrage;

        public string Description()
        {
            return $"{Marque} {Modele} ({Annee}) – {Kilometrage} km";
        }

        public string Rouler(int km)
        {
            if (km > 0)
            {
                Kilometrage += km;
                return $"La voiture a roulé {km} km. Nouveau kilométrage : {Kilometrage} km";
            }
            return "Distance invalide";
        }
    }
}
