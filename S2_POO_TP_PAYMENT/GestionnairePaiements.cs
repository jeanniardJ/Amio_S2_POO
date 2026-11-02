namespace S2_POO_TP_PAYMENT
{
    internal class GestionnairePaiements
    {
        private readonly IPaiement _paiement;

        private readonly string _typePaiement;

        public GestionnairePaiements(IPaiement paiement)
        {
            _paiement = paiement;

            _typePaiement = _paiement.GetType().Name;
        }

        /// <summary>
        /// Retrieves the payment type as a string.
        /// </summary>
        /// <returns>A string representing the payment type.</returns>
        /// <exception cref="ArgumentException">Thrown when the payment type is unrecognized.</exception>
        private string GetTypePaiement()
        {
            string typeResult;

            switch (_typePaiement)
            {
                case "PaiementCarteCredit":
                    typeResult = "carte de crédit";
                    break;
                case "PaiementCryptomonnaie":
                    typeResult = "crypto monnaie";
                    break;
                case "PaiementPayPal":
                    typeResult = "paypal";
                    break;
                default:
                    throw new ArgumentException("Erreur de type de paiement");
            }

            return typeResult;
        }

        /// <summary>
        /// Processes a payment, validates the payment information, and outputs the transaction status.
        /// </summary>
        /// <remarks>Handles multiple payment types and provides user feedback based on the validation
        /// result.</remarks>
        public void TraiterPaiement()
        {
            string statusDuPaiement = "";
            
            string resultPaiement;

            resultPaiement = (_typePaiement == "PaiementCarteCredit" || _typePaiement == "PaiementCryptomonnaie") ? $"de la {GetTypePaiement()}" : GetTypePaiement();

            switch (_paiement.EffectuerPaiement())
            {
                
                case 0:
                    statusDuPaiement = $"Echec de la validation des informations {resultPaiement}";
                    break;
                case 1:
                    statusDuPaiement = $"Validation des informations {resultPaiement}...";
                    break;
                case 2:
                    statusDuPaiement = $"Validation des informations {resultPaiement} effectuée !";
                    break;
            }

            Console.WriteLine($"{statusDuPaiement}");

            Console.WriteLine($"Paiement par {GetTypePaiement()} effectué avec {(_paiement.Valide() ? "succès":"un échec")}.");
        }

        /// <summary>
        /// Cancels the payment and logs the result of the operation.
        /// </summary>
        /// <remarks>Interacts with the payment system to attempt cancellation and outputs the outcome to
        /// the console.</remarks>
        public void AnnulerPaiment()
        {

            if (_paiement.AnnulerPaiement())
            {
                Console.WriteLine($"Annulation du paiement par {GetTypePaiement()}");
            } 
            else
            {
                Console.WriteLine($"Echec de l'annulation du paiement par {GetTypePaiement()}");
            }
        }
    }
}
