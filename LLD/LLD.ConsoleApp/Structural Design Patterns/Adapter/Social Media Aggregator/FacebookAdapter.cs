using LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator
{
    public class FacebookAdapter : ISocialMediaAdapter
    {
        private FacebookApi _facebookApi = new FacebookApi();

        public IEnumerable<ISocialMediaPost> GetPosts(long userId, long timestamp)
        {
            List<FacebookPost> posts = _facebookApi.FetchFacebookPosts(userId, timestamp);
            return ToSocialMediaPosts(posts);
        }

        private IEnumerable<ISocialMediaPost> ToSocialMediaPosts(IEnumerable<FacebookPost> posts)
        {
            List<ISocialMediaPost> messages = new List<ISocialMediaPost>();

            foreach (var post in posts)
            {
                messages.Add(new SocialMediaPost(
                    post.GetId(),
                    post.GetStatus(),
                    post.GetUserId(),
                    post.GetTimestamp()
                ));
            }

            return messages;
        }
    }
}