namespace LLD.ConsoleApp.Strategy.PricingManager;

public class DistanceBasedPricingStrategy : IPricingStrategy
{
    public double CalculatePrice(RideDetails rideDetails)
    { 
        return Fare.BASE_FARE + Fare.PER_KILOMETER_RATE * rideDetails.GetDistance();
    }
    public PricingType SupportsType()
    {
        return PricingType.DISTANCE_BASED;
    }
}
