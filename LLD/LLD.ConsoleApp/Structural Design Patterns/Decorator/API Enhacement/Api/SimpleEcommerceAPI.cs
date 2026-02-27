using LLD.ConsoleApp.Decorator.ApiEnhancement.Utils;

namespace LLD.ConsoleApp.Decorator.ApiEnhancement.Api;

public class SimpleEcommerceAPI : IApi
{
    private const string API_ENDPOINT = "http://ecommerce.api";

    public string ExecuteRequest(string requestData)
    {
        return ApiUtils.CallAPI(API_ENDPOINT, requestData);
    }
}