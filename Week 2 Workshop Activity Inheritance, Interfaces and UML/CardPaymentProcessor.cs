using System;

namespace CarRental
{
    // Pays by card. It signs the IPaymentProcessor contract.
    class CardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount, string reference)
        {
            // {amount:F2} shows the number with 2 decimal places
            Console.WriteLine($"Paid £{amount:F2} by card for {reference}");
        }
    }
}