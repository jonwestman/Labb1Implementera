using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    // Strategy Pattern
    // methods defined here must be implemented by each concrete strategy.
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
