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

        private string GetTypePaiement()
        {
            string typeResult = "";

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

        public void TraiterPaiement()
        {
            string statusDuPaiement = "";
            
            string resultPaiement = "";

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

        public void AnnulerPaiment()
        {
            //Annulation du paiement par {carte de crédit}.

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
