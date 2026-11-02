namespace S2_POO_TP_PAYMENT
{
    internal interface IPaiement
    {
        /// <summary>
        /// Determines whether the payment has been successfully completed
        /// without any errors during the payment process.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the payment is valid; otherwise, <c>false</c>.
        /// </returns>
        bool Valide();

        /// <summary>
        /// Executes the payment process.
        /// </summary>
        /// <returns>
        /// 0 if the payment failed, 1 if the payment is in progress, 2 if the payment succeeded.
        /// </returns>
        int EffectuerPaiement();

        /// <summary>
        /// Cancels the payment.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the payment was successfully canceled; otherwise, <c>false</c>.
        /// </returns>
        bool AnnulerPaiement();
    }
}
