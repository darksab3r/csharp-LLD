namespace LLD.ConsoleApp.Adapter.Translation
{
    public interface ITranslationProviderAdapter
    {
        public string Translate(TranslationRequest translationRequest);
        
        public List<string> GetSupportedLanguages();
    }
}