namespace S2_POO_TP_PAYMENT
{
    internal class GestionnairePaiements
    {
        private readonly IPaiement _paiement;

        public GestionnairePaiements(IPaiement paiement)
        {
            _paiement = paiement;
        }

        public void TraiterPaiement()
        {
            //TODO : effectuer l'affichage des payement
            _paiement.EffectuerPaiement();
            _paiement.Valide();
        }

        public void AnnulerPaiment()
        {
            //TODO : effectuer l'affichage des payement
            _paiement.AnnulerPaiement();
        }
    }
}
