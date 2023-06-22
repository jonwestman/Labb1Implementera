using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Factory
{
    internal class Basic : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Basic";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
