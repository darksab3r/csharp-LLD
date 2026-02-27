using System;

namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public class PresentationDocumentProcessor : DocumentProcessor
    {
        public PresentationDocumentProcessor(string documentName)
            : base(documentName)
        {
        }

        public override DocumentType SupportsType()
        {
            return DocumentType.PRESENTATION;
        }

        public override void ProcessDocument()
        {
            // Implement presentation document processing logic
            Console.WriteLine("Processing a presentation document: " + GetDocumentName());
            // Additional logic for presentation document processing
        }

        public void AddSlide()
        {
            Console.WriteLine("Adding a slide to the presentation.");
        }
    }
}