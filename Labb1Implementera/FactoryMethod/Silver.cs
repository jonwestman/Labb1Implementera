using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.FactoryMethod
{
    // Silver product provides implementations of the CreditCard interface methods.
    public class Silver : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Silver";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
