using System.Runtime.InteropServices.JavaScript;
using LLD.ConsoleApp.Decorator.ApiEnhancement.Api;
using LLD.ConsoleApp.Decorator.ApiEnhancement.Utils;

namespace LLD.ConsoleApp.Decorator.ApiEnhancement;

public class LoggingDecorator : BaseApiDecorator
{
    public LoggingDecorator(IApi api) : base(api) { }

    public override string ExecuteRequest(string requestData)
    {
        Logger.Log($"Processing request started at {DateTime.Now}\tRequest: {requestData}");
        string response = _api.ExecuteRequest(requestData);
        Logger.Log($"Response received at: {DateTime.Now}\tResponse: {response}");
        return response;
    }
}