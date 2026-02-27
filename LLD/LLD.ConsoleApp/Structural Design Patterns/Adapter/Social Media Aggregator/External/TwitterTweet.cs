namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External
{
    public class TwitterTweet
    {
        private string id;
        private string tweet;
        private long userId;

        public TwitterTweet(string id, string tweet, long userId)
        {
            this.id = id;
            this.tweet = tweet;
            this.userId = userId;
        }

        public string GetId()
        {
            return id;
        }

        public string GetTweet()
        {
            return tweet;
        }

        public long GetUserId()
        {
            return userId;
        }
    }
}