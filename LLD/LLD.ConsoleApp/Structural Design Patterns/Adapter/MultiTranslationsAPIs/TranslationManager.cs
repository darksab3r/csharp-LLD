using LLD.ConsoleApp.Adapter.Translation.External;

namespace LLD.ConsoleApp.Adapter.Translation
{
    public class TranslationManager
    {
        private GoogleTranslateApi googleTranslateApi = new GoogleTranslateApi();
        private MicrosoftTranslateApi microsoftTranslateApi = new MicrosoftTranslateApi();

        public string Translate(string text, string sourceLanguage, string targetLanguage, string provider)
        {
            if (provider.Equals("google"))
            {
                GoogleTranslationRequest request = new GoogleTranslationRequest(text, sourceLanguage, targetLanguage, 0.8);
                return googleTranslateApi.Convert(request);
            }
            else if (provider.Equals("microsoft"))
            {
                return microsoftTranslateApi.Translate(text, sourceLanguage, targetLanguage);
            }
            else
            {
                throw new Exception("Invalid provider");
            }
        }
    }
}