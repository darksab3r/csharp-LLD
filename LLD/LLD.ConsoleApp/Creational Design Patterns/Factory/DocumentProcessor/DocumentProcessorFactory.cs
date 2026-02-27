using System;

namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public class DocumentProcessorFactory
    {
        public DocumentProcessor CreateProcessor(DocumentType documentType, string documentName)
        {

            switch (documentType)
            {
                case DocumentType.TEXT:
                    return new TextDocumentProcessor(documentName);

                case DocumentType.PRESENTATION:
                    return new PresentationDocumentProcessor(documentName);

                case DocumentType.SPREAD_SHEET:
                    return new SpreadsheetDocumentProcessor(documentName);

                default:
                    throw new ArgumentException("Unsupported document type");
            }
        }
    }
}