namespace LLD.ConsoleApp.Strategy.PricingManager;

public interface IPricingStrategy
{
    PricingType SupportsType();
    Double CalculatePrice(RideDetails rideDetails);

}