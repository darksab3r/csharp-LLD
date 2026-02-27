using LLD.ConsoleApp.Decorator.ApiEnhancement.Api;
using LLD.ConsoleApp.Decorator.ApiEnhancement.Utils;

namespace LLD.ConsoleApp.Decorator.ApiEnhancement;

public class RateLimitingDecorator : BaseApiDecorator
{
    public RateLimitingDecorator(IApi api) : base(api) { }

    public override string ExecuteRequest(string requestData)
    {
        if (ApiUtils.RateLimitExceeded(requestData))
        {
            throw new RateLimitExceededException("Rate limit exceeded.");
        }
        Console.WriteLine("Rate limit check passed.");
        return _api.ExecuteRequest(requestData);
    }
}