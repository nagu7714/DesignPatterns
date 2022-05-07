using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annaulCharge;
        public PlatinumFactory(int creditLimit,int annualCharge)
        {
            _creditLimit = creditLimit;
            _annaulCharge = annualCharge;
        }
        public override CreditCard GetCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annaulCharge);
        }
    }
}
