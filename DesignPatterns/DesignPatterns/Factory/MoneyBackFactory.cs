using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class MoneyBackFactory : CardFactory
    {

        private int _creditLimit;
        private int _annaulCharge;
        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annaulCharge = annualCharge;
        }
        public override CreditCard GetCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annaulCharge);
        }
    }
}

