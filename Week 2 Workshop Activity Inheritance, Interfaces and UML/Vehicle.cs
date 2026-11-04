using System;

namespace CarRental
{
    // Vehicle is the base class. Every car "is a" vehicle,
    // so the shared details live here.
    class Vehicle
    {
        // Make is the brand, for example Toyota
        public string Make { get; }

        // Model is the type, for example Corolla
        public string Model { get; }

        // The constructor sets Make and Model as soon as a Vehicle is created
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // Prints only the make and model
        public void ShowBasicInfo()
        {
            Console.WriteLine("Vehicle: " + Make + " " + Model);
        }
    }
}