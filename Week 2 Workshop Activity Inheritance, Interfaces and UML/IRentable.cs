namespace CarRental
{
    // A contract for anything that can be rented
    interface IRentable
    {
        // Works out the total cost for a number of days
        double CalculateCost(int days);

        // Rents the item for a number of days
        void Rent(int days);
    }
}