namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External;

public interface ISocialMediaPost
{
    string GetId();
    string GetText();
    long GetUserId();
    long GetTimestamp();
}