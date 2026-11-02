using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_PAYMENT
{
    internal abstract class APaiement
    {
        protected bool _payementIsValid;

        protected bool _payementIsAnnuler;

        protected int _payementProcess;

        /// <summary>
        /// Determines whether the payment can be canceled.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the payment is eligible for cancellation;
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool AnnulerPaiement()
        {
            if (_payementIsValid || _payementProcess == 0)
            {
                return _payementIsAnnuler;
            }

            _payementIsAnnuler = true;

            return _payementIsAnnuler;
        }

        /// <summary>
        /// Executes the payment process.
        /// </summary>
        /// <returns>
        /// 0 if the payment cannot be processed because it has already been
        /// validated or is currently being canceled;
        /// 1 while the payment is being processed;
        /// 2 when the payment has been successfully completed.
        /// </returns>
        public abstract int EffectuerPaiement();

        /// <summary>
        /// Determines whether the payment can be validated.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the payment is neither canceled, currently being processed,
        /// nor already validated; otherwise, <c>false</c>.
        /// </returns>
        public bool Valide()
        {
            if (_payementIsAnnuler || _payementProcess == 1 || _payementIsValid )
                return _payementIsValid;

            _payementIsValid = true;

            return _payementIsValid;
        }
    }
}
