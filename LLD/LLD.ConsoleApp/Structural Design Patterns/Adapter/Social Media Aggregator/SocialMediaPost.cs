using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;
using System.Collections.Generic;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator
{
    public class SocialMediaManager
    {
        private FacebookApi facebookApi = new FacebookApi();
        private TwitterApi twitterApi = new TwitterApi();

        public void GetMessages(long userId, long timestamp, string platform)
        {
            if (platform.Equals("facebook"))
            {
                List<FacebookPost> posts = facebookApi.FetchFacebookPosts(userId, timestamp);
            }
            else if (platform.Equals("twitter"))
            {
                List<TwitterTweet> tweets = twitterApi.GetTweets(userId);
            }

            // Convert the posts/tweets to a common format
        }
    }
}