using System;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Each car now has a daily rate as the last value
            Car car1 = new Car("Toyota", "Corolla", "AB12 CDE", 45.00);
            Car car2 = new Car("Ford", "Focus", "XY34 ZZZ", 50.00);
            Car car3 = new Car("Honda", "Civic", "LM56 NOP", 60.00);

            // Exercise 1 demo
            car1.ShowBasicInfo();
            car1.ShowFullInfo();
            car2.ShowBasicInfo();
            car2.ShowFullInfo();
            car3.ShowBasicInfo();
            car3.ShowFullInfo();
            Console.WriteLine();

            // Quick test of the new rental methods
            car1.Rent(3);
            double total = car1.CalculateCost(3);
            Console.WriteLine($"Total cost: £{total:F2}");

            // One variable of the interface type can hold either payment class
            IPaymentProcessor processor = new CardPaymentProcessor();
            processor.ProcessPayment(total, car1.RegistrationNumber);

            processor = new CashPaymentProcessor();
            processor.ProcessPayment(total, car1.RegistrationNumber);
        }
    }
}