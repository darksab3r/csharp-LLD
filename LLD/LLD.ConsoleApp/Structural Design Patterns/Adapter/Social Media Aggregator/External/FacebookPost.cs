namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External
{
    public class FacebookPost
    {
        private string id;
        private string status;
        private long userId;
        private long timestamp;

        public FacebookPost(string id, string status, long userId, long timestamp)
        {
            this.id = id;
            this.status = status;
            this.userId = userId;
            this.timestamp = timestamp;
        }

        public string GetId()
        {
            return id;
        }

        public string GetStatus()
        {
            return status;
        }

        public long GetUserId()
        {
            return userId;
        }

        public long GetTimestamp()
        {
            return timestamp;
        }
    }
}