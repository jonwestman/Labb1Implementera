﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    // Singleton Pattern
    public class CreditCardFactory
    {
        private static CreditCardFactory _instance;

        private CreditCardFactory() { }

        public static CreditCardFactory GetInstance()
        {
            if (_instance == null)
                _instance = new CreditCardFactory();

            return _instance;
        }

        // Factory Method
        public CreditCard CreateCreditCard(string cardType)
        {
            switch (cardType)
            {
                case "Visa":
                    return new VisaCreditCard();
                case "Mastercard":
                    return new MastercardCreditCard();
                default:
                    throw new NotSupportedException($"Credit card type '{cardType}' is not supported.");
            }
        }
    }
}
