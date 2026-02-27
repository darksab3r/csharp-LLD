using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator
{
    public class SocialMediaPost : ISocialMediaPost
    {
        private string id;
        private string text;
        private long userId;
        private long timestamp;

        public SocialMediaPost(string id, string text, long userId, long timestamp)
        {
            this.id = id;
            this.text = text;
            this.userId = userId;
            this.timestamp = timestamp;
        }

        public string GetId() => id;
        public string GetText() => text;
        public long GetUserId() => userId;
        public long GetTimestamp() => timestamp;
    }
}