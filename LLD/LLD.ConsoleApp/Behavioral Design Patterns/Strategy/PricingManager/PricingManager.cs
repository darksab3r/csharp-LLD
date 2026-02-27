namespace LLD.ConsoleApp.Strategy.PricingManager;

public class PricingManager
{
    private PricingType _pricingType;
    private IPricingStrategy _pricingStrategy;

    public PricingManager(PricingType pricingType)
    {
        this._pricingType = pricingType;
        this._pricingStrategy = PricingStrategyFactory.GetPricingStrategy(_pricingType);
    }

    public Double CalculatePrice(RideDetails rideDetails)
    {
        return this._pricingStrategy.CalculatePrice(rideDetails);
    }
}