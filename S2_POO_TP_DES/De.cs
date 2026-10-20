namespace S2_POO_TP_DES;

internal class De
{
    private static int _cptInstance;
    private static readonly Random _random = new();

    private int _valeur;
    private readonly int _numero;
    
    public De()
    {
        _numero = ++_cptInstance;
    }

    public int Lancer()
    {
        //retourne une valeur entre 1 à 6
        _valeur = _random.Next(1, 7);
        
        return _valeur;
    }

    public void Print()
    {
        Console.WriteLine($"Dé n°{_numero} : {_valeur}");
    }
}