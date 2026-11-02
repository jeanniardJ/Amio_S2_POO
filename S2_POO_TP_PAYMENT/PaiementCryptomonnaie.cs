namespace S2_POO_TP_PAYMENT
{
    internal class PaiementCryptomonnaie : IPaiement
    {
        public void AnnulerPaiement()
        {
            Console.WriteLine("Annulation du paiement par crypto monnaie.");
        }

        public void EffectuerPaiement()
        {
            Console.WriteLine("Validation des informations de la crypto monnaie...");
        }

        public bool Valide()
        {
            Console.WriteLine("Paiement par crypto monnaie effectué avec succès.");
            return true;
        }
    }
}
