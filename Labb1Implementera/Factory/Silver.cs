using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Factory
{
    internal class Silver : ICreditCard
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
