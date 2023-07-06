using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.FactoryMethod
{
    // Guld Product provides implementations of the CreditCard interface methods.
    public class Guld : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Guld";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
