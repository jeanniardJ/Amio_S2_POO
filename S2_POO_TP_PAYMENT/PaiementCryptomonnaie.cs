namespace S2_POO_TP_PAYMENT
{
    internal class PaiementCryptomonnaie : APaiement, IPaiement
    {
        public override int EffectuerPaiement()
        {
            int reslt = 0;

            if (AnnulerPaiement() && Valide())
                return 0;

            reslt = 1;
            //Temps donner pour un traitement par carte
            Thread.Sleep(5000);

            //Payement effectuer
            reslt = 2;

            return reslt;
        }
    }
}
