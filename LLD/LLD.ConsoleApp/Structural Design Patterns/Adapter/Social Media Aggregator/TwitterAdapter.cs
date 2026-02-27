using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator
{
    public class TwitterAdapter : ISocialMediaAdapter
    {
        private TwitterApi twitterApi = new TwitterApi();

        public IEnumerable<ISocialMediaPost> GetPosts(long userId, long timestamp)
        {
            List<TwitterTweet> posts = twitterApi.GetTweets(userId);
            return ToSocialMediaPosts(posts);
        }

        private IEnumerable<ISocialMediaPost> ToSocialMediaPosts(IEnumerable<TwitterTweet> posts)
        {
            List<ISocialMediaPost> messages = new List<ISocialMediaPost>();

            foreach (var post in posts)
            {
                messages.Add(new SocialMediaPost(
                    post.GetId(),
                    post.GetTweet(),
                    post.GetUserId(),
                    0L   // Twitter API does not provide timestamp
                ));
            }

            return messages;
        }
    }
}