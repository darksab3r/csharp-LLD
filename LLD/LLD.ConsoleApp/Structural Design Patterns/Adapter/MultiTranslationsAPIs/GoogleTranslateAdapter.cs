namespace LLD.ConsoleApp.Adapter.Translation.External;

public class GoogleTranslateAdapter:ITranslationProviderAdapter
{
    private GoogleTranslateApi _googleTranslateApi = new GoogleTranslateApi();
    public string Translate(TranslationRequest translationRequest)
    {
        GoogleTranslationRequest googleTranslationRequest = ToGoogleTranslationRequest(translationRequest);
        return _googleTranslateApi.Convert(googleTranslationRequest);
    }
    public List<string> GetSupportedLanguages()
    {
       return _googleTranslateApi.GetLanguages();
    }
    
    private GoogleTranslationRequest ToGoogleTranslationRequest(TranslationRequest translationRequest)
    {
        return new GoogleTranslationRequest(translationRequest.Text,
            translationRequest.SourceLanguage,
            translationRequest.TargetLanguage,
            translationRequest.ConfidenceThreshold);
    }
    
}