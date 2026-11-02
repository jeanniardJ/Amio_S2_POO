namespace S2_POO_TP_PAYMENT
{
    internal class GestionnairePaiements
    {
        private IPaiement Paiement;

        public GestionnairePaiements(IPaiement paiement)
        {
            Paiement = paiement;
        }

        public void TraiterPaiement()
        {
            Paiement.EffectuerPaiement();
            Paiement.Valide();
        }

        public void AnnulerPaiment()
        {
            Paiement.AnnulerPaiement();
        }
    }
}
