using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    // Strategy Pattern
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private readonly CreditCard _creditCard;

        public CreditCardPaymentStrategy(CreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} made using {_creditCard.GetCardType()} credit card.");
        }
    }
}
