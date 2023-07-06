using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    // Factory Method
    // Concrete class
    public class MastercardCreditCard : CreditCard
    {
        public override string GetCardType()
        {
            return "Mastercard";
        }
    }
}
