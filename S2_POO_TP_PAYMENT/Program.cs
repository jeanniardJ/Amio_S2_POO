namespace S2_POO_TP_PAYMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix;
            bool isOkTry = false;

            do
            {
                Console.WriteLine("Sélectionnez le type de paiement (1: Carte de Crédit, 2: PayPal, 3: Cryptomonnaie) : ");
                //retourne true ou false si l'entrée utilisateur est un entier et entre 1 et 3
                isOkTry = int.TryParse(Console.ReadLine(), out choix) && choix is >= 1 and <= 3;
                
            } while (!isOkTry);
            

            IPaiement paiement = choix switch
            {
                1 => new PaiementCarteCredit(),
                2 => new PaiementPayPal(),
                3 => new PaiementCryptomonnaie()
            };

            GestionnairePaiements gestionnaire = new GestionnairePaiements(paiement);

            Console.WriteLine("\nTraitement du paiement :");
            gestionnaire.TraiterPaiement();
            Console.WriteLine("\nAnnulation du paiement :");
            gestionnaire.AnnulerPaiment();
        }
    }
}
