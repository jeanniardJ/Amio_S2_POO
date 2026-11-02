namespace S2_POO_TP_PAYMENT
{
    internal class PaiementPayPal : IPaiement
    {
        public void AnnulerPaiement()
        {
            Console.WriteLine("Annulation du paiement par paypal.");
        }

        public void EffectuerPaiement()
        {
            Console.WriteLine("Validation des informations de paypal...");
        }

        public bool Valide()
        {
            Console.WriteLine("Paiement par paylpal effectué avec succès.");
            return true;
        }
    }
}
