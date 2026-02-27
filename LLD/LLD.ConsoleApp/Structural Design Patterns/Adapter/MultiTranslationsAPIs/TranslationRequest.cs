namespace LLD.ConsoleApp.Adapter.Translation
{
    public class TranslationRequest
    {
        public string Text { get; }
        public string SourceLanguage { get; }
        public string TargetLanguage { get; }
        public double ConfidenceThreshold { get; }
        
        public TranslationRequest(string text, string sourceLanguage, string targetLanguage, double confidenceThreshold = 0)
        {
            Text = text;
            SourceLanguage = sourceLanguage;
            TargetLanguage = targetLanguage;
            ConfidenceThreshold = confidenceThreshold;
        }
    }
}