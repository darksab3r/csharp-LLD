using LLD.ConsoleApp.Adapter.SocialMediaAggregator;
using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator
{
    public interface ISocialMediaAdapter
    {
        IEnumerable<ISocialMediaPost> GetPosts(long userId, long timestamp);
    }
}