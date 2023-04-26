namespace dependencyInversion.abstracts;

public class StripePaymentProvider : IPaymentProvider
{
    public bool ProcessPayment(string cardNumber, int expirationMonth, int expirationYear, decimal amount)
    {
        // Stripe transactions
        return true;
    }
}