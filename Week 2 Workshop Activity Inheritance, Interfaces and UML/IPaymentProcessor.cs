namespace CarRental
{
    // A contract for any way of taking payment
    interface IPaymentProcessor
    {
        // Takes a payment. The reference says what the payment is for.
        void ProcessPayment(double amount, string reference);
    }
}