using LLD.ConsoleApp.Decorator.ApiEnhancement.Api;

namespace LLD.ConsoleApp.Decorator.ApiEnhancement;

public abstract class BaseApiDecorator : IApi
{
    protected IApi _api;

    public BaseApiDecorator(IApi api)
    {
        _api = api;
    }

    public virtual string ExecuteRequest(string requestData)
    {
        return _api.ExecuteRequest(requestData);
    }
}