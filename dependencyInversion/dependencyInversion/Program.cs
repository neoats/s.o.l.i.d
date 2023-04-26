using dependencyInversion.abstracts;
using dependencyInversion.concretes;

namespace dependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stripe kullanarak ödeme işlemini gerçekleştirme
            var paymentManager = new PaymentManager(new StripePaymentProvider());
            paymentManager.ProcessPayment("4242-4242-4242-4242", 12, 2023, 100.00M);

            // Paypal kullanarak ödeme işlemini gerçekleştirme
            var paymentManager2 = new PaymentManager(new PaypalPaymentProvider());
            paymentManager.ProcessPayment("23-632-552-1112", 4, 2024, 50000.00M);
        }
    }
}