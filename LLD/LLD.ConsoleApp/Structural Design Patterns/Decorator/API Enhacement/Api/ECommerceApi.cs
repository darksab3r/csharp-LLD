namespace LLD.ConsoleApp.Decorator.ApiEnhancement.Api;

public class ECommerceApi
{
    public string ExecuteRequest(string requestData)
    {
        IApi api = new SimpleEcommerceAPI();
        api = new RateLimitingDecorator(api);
        api = new LoggingDecorator(api);
        
        return api.ExecuteRequest(requestData);
    }
}