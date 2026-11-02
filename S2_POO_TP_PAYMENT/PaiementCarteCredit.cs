namespace S2_POO_TP_PAYMENT
{
    internal class PaiementCarteCredit : IPaiement
    {
        public void AnnulerPaiement()
        {
            Console.WriteLine("Annulation du paiement par carte de crédit.");
        }

        public void EffectuerPaiement()
        {
            Console.WriteLine("Validation des informations de la carte de crédit...");
        }

        public bool Valide()
        {
            Console.WriteLine("Paiement par carte de crédit effectué avec succès.");
            return true;
        }
    }
}
