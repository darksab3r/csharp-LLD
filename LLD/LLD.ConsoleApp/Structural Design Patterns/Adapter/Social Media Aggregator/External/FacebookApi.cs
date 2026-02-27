using System.Collections.Generic;
using static LLD.ConsoleApp.Adapter.SocialMediaAggregator.External.ApiUtils;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External
{
    public class FacebookApi
    {
        public List<FacebookPost> FetchFacebookPosts(long userId, long timestamp)
        {
            // Implementation to fetch Facebook posts
            LogFacebookGetPosts();
            return new List<FacebookPost> { new FacebookPost("1", "Hello World", 1L, 123456789L) };
        }

        public void PostFacebookStatus(long user, string status)
        {
            // Implementation to post a status on Facebook
            LogFacebookPostStatus();
        }
    }
}