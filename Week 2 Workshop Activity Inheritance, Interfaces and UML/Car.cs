using System;

namespace CarRental
{
    // Car inherits from Vehicle AND signs the IRentable contract.
    // The base class goes first, then the interface.
    class Car : Vehicle, IRentable
    {
        public string RegistrationNumber { get; }

        // How much it costs to rent this car for one day
        public double DailyRate { get; }

        // The constructor now also takes the daily rate
        public Car(string make, string model, string registrationNumber, double dailyRate)
            : base(make, model)
        {
            RegistrationNumber = registrationNumber;
            DailyRate = dailyRate;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine("Car: " + Make + " " + Model + " (" + RegistrationNumber + ")");
        }

        // From IRentable: total cost is days multiplied by the daily rate
        public double CalculateCost(int days)
        {
            return days * DailyRate;
        }

        // From IRentable: prints a message saying the car was rented
        public void Rent(int days)
        {
            Console.WriteLine("Car " + RegistrationNumber + " rented for " + days + " day(s).");
        }
    }
}