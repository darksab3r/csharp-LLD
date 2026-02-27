using System;

namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public class TextDocumentProcessor : DocumentProcessor
    {
        public TextDocumentProcessor(string documentName)
            : base(documentName)    
        {
        }

        public override DocumentType SupportsType()
        {
            return DocumentType.TEXT;
        }

        public override void ProcessDocument()
        {
            // Implement text document processing logic
            Console.WriteLine("Processing a text document: " + GetDocumentName());
            // Additional logic for text document processing
        }
    }
}