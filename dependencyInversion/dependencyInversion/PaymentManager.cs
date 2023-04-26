namespace dependencyInversion.abstracts;

public class PaymentManager
{
    private readonly IPaymentProvider _paymentProvider;

    public PaymentManager(IPaymentProvider paymentProvider)
    {
        _paymentProvider = paymentProvider;
    }

    public bool ProcessPayment(string cardNumber, int expirationMonth, int expirationYear, decimal amount)
    {
        return _paymentProvider.ProcessPayment(cardNumber, expirationMonth, expirationYear, amount);
    }
}