namespace S2_POO_TP_PAYMENT
{
    internal interface IPaiement
    {
        /// <summary>
        /// Paiement validé si aucun échec lors du processus de paiement.
        /// </summary>
        /// <returns></returns>
        bool Valide();

        /// <summary>
        /// Processes a payment operation.
        /// </summary>
        void EffectuerPaiement();

        /// <summary>
        /// Cancels the payment.
        /// </summary>
        void AnnulerPaiement();
    }
}
