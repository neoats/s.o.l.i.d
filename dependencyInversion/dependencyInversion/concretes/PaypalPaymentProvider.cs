using dependencyInversion.abstracts;

namespace dependencyInversion.concretes;

public class PaypalPaymentProvider : IPaymentProvider
{
    public bool ProcessPayment(string cardNumber, int expirationMonth, int expirationYear, decimal amount)
    {
        // Paypal transactions
        return true;
    }
}