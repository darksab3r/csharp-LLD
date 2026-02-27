namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public abstract class DocumentProcessor
    {
        protected string _documentName;

        protected DocumentProcessor(string documentName)
        {
            _documentName = documentName;
        }

        public string GetDocumentName()
        {
            return _documentName;
        }

        public abstract DocumentType SupportsType();

        public abstract void ProcessDocument();
    }
}