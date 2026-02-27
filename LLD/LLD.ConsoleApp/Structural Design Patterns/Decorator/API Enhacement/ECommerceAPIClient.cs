using LLD.ConsoleApp.Decorator.ApiEnhancement.Api;

namespace LLD.ConsoleApp.Decorator.ApiEnhancement;

public class ECommerceAPIClient
{
    public void Run()
    {
        ECommerceApi api = new ECommerceApi();
        string response = api.ExecuteRequest("sample request data");
        Console.WriteLine(response);
    }
}