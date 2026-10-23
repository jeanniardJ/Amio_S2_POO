namespace S2_POO_TP_PAYMENT
{
    internal interface IPaiement
    {
        bool Valide();

        void EffectuerPaiement();

        void AnnulerPaiement();
    }
}
