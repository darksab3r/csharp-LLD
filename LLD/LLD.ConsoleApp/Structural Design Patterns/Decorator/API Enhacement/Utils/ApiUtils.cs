namespace LLD.ConsoleApp.Decorator.ApiEnhancement.Utils;

public class ApiUtils
{
    private static int _requestCount = 0;
    private const int RATE_LIMIT = 3;

    public static string CallAPI(string url, string requestData)
    {
        return $"API created with data: {requestData} at {url}";
    }

    public static bool RateLimitExceeded(string apiEndpoint)
    {
        _requestCount++;
        return _requestCount > RATE_LIMIT;
    }
}