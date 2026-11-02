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

                isOkTry = int.TryParse(Console.ReadLine(), out choix) ? true : false;

                if(choix != 1 && choix != 2 && choix != 3)
                {
                    isOkTry = false;
                }
                
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
