using System;

namespace LLD.ConsoleApp.Strategy.PricingManager;

public static class PricingStrategyFactory
{
    public static IPricingStrategy GetPricingStrategy(PricingType pricingType)
    {
        return pricingType switch
        {
            PricingType.DISTANCE_BASED => new DistanceBasedPricingStrategy(),
            PricingType.TIME_BASED => new TimeBasedPricingStrategy(),
            PricingType.SURGE => new SurgePricingStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(pricingType), pricingType, null)
        };
    }
}
