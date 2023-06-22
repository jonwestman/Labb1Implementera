using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Factory
{
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType) 
        {
            ICreditCard cardDetails = null;

            switch (cardType)
            {
                case "Basic":
                    cardDetails = new Basic();
                    break;
                case "Silver":
                    cardDetails = new Silver();
                    break;
                case "Guld":
                    cardDetails = new Guld();
                    break;
            }

            return cardDetails;
        }
    }
}
