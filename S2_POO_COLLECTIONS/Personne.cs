namespace S2_POO_COLLECTIONS
{
    internal class Personne(string prenom, string nom, int age)
    {
        public string Prenom { get; set; } = prenom;
        public string Nom { get; set; } = nom;
        public int Age { get; set; } = age;

        public string SePresenter()
        {
            return $"Je m'appelle {Prenom} {Nom} et j'ai {Age} ans.";
        }
    }

}
