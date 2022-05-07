using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class TitaniumFactory: CardFactory
    {

        private int _creditLimit;
        private int _annaulCharge;
        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annaulCharge = annualCharge;
        }
        public override CreditCard GetCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annaulCharge);
        }
    }
}
