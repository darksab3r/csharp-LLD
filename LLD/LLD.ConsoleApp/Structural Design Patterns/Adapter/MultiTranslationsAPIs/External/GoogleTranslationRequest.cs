namespace LLD.ConsoleApp.Adapter.Translation.External
{
    public class GoogleTranslationRequest
    {
        public string Text { get; }
        public string SourceLanguage { get; }
        public string TargetLanguage { get; }
        public double ConfidenceThreshold { get; }

        public GoogleTranslationRequest(string text, string sourceLanguage, string targetLanguage, double confidenceThreshold)
        {
            Text = text;
            SourceLanguage = sourceLanguage;
            TargetLanguage = targetLanguage;
            ConfidenceThreshold = confidenceThreshold;
        }
    }
}