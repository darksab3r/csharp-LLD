using System.Collections.Generic;
using LLD.ConsoleApp.Adapter.SocialMediaAggregator;
using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;
using LLD.ConsoleApp.Structural_Design_Patterns.Adapter.Social_Media_Aggregator.External;

namespace LLD.ConsoleApp.Adapter.SocialMedia;

public class SocialMediaManager
{
    public IEnumerable<ISocialMediaPost> GetMessages(long userId, long timestamp, string platform)
    {
        // Get adapter from factory
        ISocialMediaAdapter adapter = SocialMediaAdapterFactory.GetAdapter(platform);

        // Delegate to adapter
        return adapter.GetPosts(userId, timestamp);
    }
}