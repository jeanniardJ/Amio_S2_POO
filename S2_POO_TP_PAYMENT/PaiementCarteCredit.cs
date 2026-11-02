using System.Net.Http.Headers;

namespace S2_POO_TP_PAYMENT
{
    internal class PaiementCarteCredit : APaiement, IPaiement
    {
        public override int EffectuerPaiement()
        {
            if (_payementIsValid || _payementIsAnnuler)
                return _payementProcess;


            _payementProcess = 1;
            //Temps donner pour un traitement par carte
            Thread.Sleep(2500);

            //Payement effectuer
            _payementProcess = 2;

            return _payementProcess;
        }
    }
}
