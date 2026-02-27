using LLD.ConsoleApp.Adapter.SocialMediaAggregator;

namespace LLD.ConsoleApp.Structural_Design_Patterns.Adapter.Social_Media_Aggregator.External;

public class SocialMediaAdapterFactory
{
    public static ISocialMediaAdapter GetAdapter (string type)
    {
        return type switch
        {
            nameof(SocialMediaPlatformType.Facebook) => new FacebookAdapter(),
            nameof(SocialMediaPlatformType.Twitter) => new TwitterAdapter(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}