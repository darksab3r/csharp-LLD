using LLD.ConsoleApp.Adapter.Translation;
using LLD.ConsoleApp.Adapter.Translation.External;

namespace LLD.ConsoleApp.Structural_Design_Patterns.Adapter.MultiTranslationsAPIs;

public class MicrosoftTranslationAdapter:ITranslationProviderAdapter
{
    private MicrosoftTranslateApi _microsoftTranslateApi = new MicrosoftTranslateApi();
    
    public string Translate(TranslationRequest translationRequest)
    {
        return _microsoftTranslateApi.Translate(translationRequest.Text,translationRequest.SourceLanguage,translationRequest.TargetLanguage);
    }
    
    public List<string> GetSupportedLanguages()
    {
        return _microsoftTranslateApi.GetSupportedLanguages();
    }
}