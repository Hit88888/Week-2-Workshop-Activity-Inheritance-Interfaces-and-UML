using System;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes sure the pound sign shows correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ---------- Exercise 1 demo: inheritance ----------
            Car car1 = new Car("Toyota", "Corolla", "AB12 CDE", 45.00);
            Car car2 = new Car("Ford", "Focus", "XY34 ZZZ", 50.00);
            Car car3 = new Car("Honda", "Civic", "LM56 NOP", 60.00);

            car1.ShowBasicInfo();
            car1.ShowFullInfo();
            car2.ShowBasicInfo();
            car2.ShowFullInfo();
            car3.ShowBasicInfo();
            car3.ShowFullInfo();
            Console.WriteLine();

            // ---------- Exercise 2 demo: rental and payment ----------

            // Step 1: the car being rented is car1 (Toyota Corolla, 45.00 per day)
            Car rentalCar = car1;

            // Step 2: ask for the number of days, and keep asking until it is valid
            int days = 0;
            bool daysValid = false;
            while (!daysValid)
            {
                Console.Write("Enter number of rental days: ");
                string daysText = Console.ReadLine();

                // TryParse is true only if the text is a whole number.
                // We also check the number is above zero.
                if (int.TryParse(daysText, out days) && days > 0)
                {
                    daysValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a whole number greater than 0.");
                }
            }

            // Step 3: rent the car
            rentalCar.Rent(days);

            // Step 4: work out the total cost
            double totalCost = rentalCar.CalculateCost(days);
            Console.WriteLine($"Total cost: £{totalCost:F2}");

            // Step 5: ask for the payment type, and keep asking until it is 1 or 2
            int choice = 0;
            bool choiceValid = false;
            while (!choiceValid)
            {
                Console.Write("Choose payment type (1 = Card, 2 = Cash): ");
                string choiceText = Console.ReadLine();

                if (int.TryParse(choiceText, out choice) && (choice == 1 || choice == 2))
                {
                    choiceValid = true;
                }
                else
                {
                    Console.WriteLine("Please type 1 for Card or 2 for Cash.");
                }
            }

            // The variable type is the interface, so it can hold either payment class
            IPaymentProcessor processor;
            string paymentName;

            if (choice == 1)
            {
                processor = new CardPaymentProcessor();
                paymentName = "card";
            }
            else
            {
                processor = new CashPaymentProcessor();
                paymentName = "cash";
            }

            // Step 6: take the payment, using the registration number as the reference
            processor.ProcessPayment(totalCost, rentalCar.RegistrationNumber);

            // Step 7: print a short receipt
            Console.WriteLine($"Receipt: {rentalCar.Make} {rentalCar.Model} ({rentalCar.RegistrationNumber}), {days} day(s), £{totalCost:F2}, paid by {paymentName}.");

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}