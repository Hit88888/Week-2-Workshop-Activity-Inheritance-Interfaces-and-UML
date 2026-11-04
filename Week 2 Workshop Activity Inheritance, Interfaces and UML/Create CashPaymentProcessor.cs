using System;

namespace CarRental
{
    // Pays by cash. It signs the same contract, but prints a different message.
    class CashPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount, string reference)
        {
            Console.WriteLine($"Paid £{amount:F2} in cash for {reference}");
        }
    }
}