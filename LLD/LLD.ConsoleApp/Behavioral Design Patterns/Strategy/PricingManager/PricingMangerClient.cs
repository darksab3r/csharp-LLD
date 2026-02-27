using System;

namespace LLD.ConsoleApp.Strategy.PricingManager
{
    public class PricingManagerClient
    {
        public void Run()
        {
            Console.WriteLine("PricingManager Client Started");

            // Test RideDetails creation
            RideDetails ride = new RideDetails(12.5, 30);

            Console.WriteLine($"Distance: {ride.GetDistance()}");
            Console.WriteLine($"Duration: {ride.GetDuration()}");

            // Test PricingManager structure
            PricingManager manager1 = new PricingManager(PricingType.SURGE);
            PricingManager manager2 = new PricingManager(PricingType.DISTANCE_BASED);
            PricingManager manager3 = new PricingManager(PricingType.TIME_BASED);
            // No PricingStrategy implementation exists in provided files
            // So we only test object creation and method availability

            Console.WriteLine($"Surge Fare :{manager1.CalculatePrice(ride)}");

            // Calling CalculatePrice without strategy would throw (same as Java)
            // manager.CalculatePrice(ride);
        }
    }
}
