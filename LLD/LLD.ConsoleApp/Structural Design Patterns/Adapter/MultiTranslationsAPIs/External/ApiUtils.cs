namespace LLD.ConsoleApp.Adapter.Translation.External
{
    public class ApiUtils
    {
        public static void LogGoogleGetSupportedLanguages()
        {
            Console.WriteLine("Getting supported languages from Google Translate API");
        }

        public static void LogGoogleTranslate()
        {
            Console.WriteLine("Translating text using Google Translate API");
        }

        public static void LogMicrosoftGetSupportedLanguages()
        {
            Console.WriteLine("Getting supported languages from Microsoft Translator API");
        }

        public static void LogMicrosoftTranslate()
        {
            Console.WriteLine("Translating text using Microsoft Translator API");
        }
    }
}