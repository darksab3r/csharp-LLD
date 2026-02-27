using System.Collections.Generic;
using static LLD.ConsoleApp.Adapter.SocialMediaAggregator.External.ApiUtils;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External
{
    public class TwitterApi
    {
        public List<TwitterTweet> GetTweets(long userId)
        {
            // Implementation to fetch Twitter tweets
            LogTwitterGetPosts();
            return new List<TwitterTweet> { new TwitterTweet("1", "Hello World", 1L) };
        }

        public void Tweet(long userId, string text)
        {
            // Implementation to send a tweet on Twitter
            LogTwitterPostStatus();
        }
    }
}