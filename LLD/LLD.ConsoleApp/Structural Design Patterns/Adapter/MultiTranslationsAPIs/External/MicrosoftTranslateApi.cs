using static LLD.ConsoleApp.Adapter.Translation.External.ApiUtils;

namespace LLD.ConsoleApp.Adapter.Translation.External
{
    public class MicrosoftTranslateApi
    {
        public string Translate(string text, string sourceLanguage, string targetLanguage)
        {
            LogMicrosoftTranslate();
            return "Translated text";
        }

        public List<string> GetSupportedLanguages()
        {
            LogMicrosoftGetSupportedLanguages();
            return new List<string> { "hindi", "marathi", "kannada" };
        }
    }
}