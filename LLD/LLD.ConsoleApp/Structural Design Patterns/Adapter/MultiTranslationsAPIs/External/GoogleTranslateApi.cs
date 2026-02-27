using static LLD.ConsoleApp.Adapter.Translation.External.ApiUtils;

namespace LLD.ConsoleApp.Adapter.Translation.External
{
    public class GoogleTranslateApi
    {
        public string Convert(GoogleTranslationRequest request)
        {
            LogGoogleTranslate();
            return "Translated text";
        }

        public List<string> GetLanguages()
        {
            LogGoogleGetSupportedLanguages();
            return new List<string> { "hindi", "marathi", "kannada" };
        }
    }
}