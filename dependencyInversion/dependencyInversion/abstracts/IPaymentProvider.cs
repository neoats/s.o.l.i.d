using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInversion.abstracts
{
    public interface IPaymentProvider
    {
        bool ProcessPayment(string cardNumber, int expirationMonth, int expirationYear, decimal amount);
    }
}

