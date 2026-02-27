namespace LLD.ConsoleApp.Strategy.PricingManager;

public class TimeBasedPricingStrategy: IPricingStrategy
{
    public double CalculatePrice(RideDetails rideDetails)
    { 
        return Fare.BASE_FARE + Fare.PER_MINUTE_RATE * rideDetails.GetDuration();
    }
    public PricingType SupportsType()
    {
        return PricingType.TIME_BASED;
    }
}
