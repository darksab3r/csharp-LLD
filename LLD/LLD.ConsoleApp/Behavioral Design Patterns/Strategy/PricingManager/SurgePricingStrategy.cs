namespace LLD.ConsoleApp.Strategy.PricingManager;

public class SurgePricingStrategy : IPricingStrategy
{
    public PricingType SupportsType()
    {
        return PricingType.SURGE;
    }

    public double CalculatePrice(RideDetails rideDetails)
    { 
        return Fare.BASE_FARE * Fare.SURGE_MULTIPLIER;
    }
}
