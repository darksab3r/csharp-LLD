using System;

namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public class SpreadsheetDocumentProcessor : DocumentProcessor
    {
        public SpreadsheetDocumentProcessor(string documentName)
            : base(documentName)
        {
        }

        public override DocumentType SupportsType()
        {
            return DocumentType.SPREAD_SHEET;
        }

        public override void ProcessDocument()
        {
            // Implement spreadsheet document processing logic
            Console.WriteLine("Processing a spreadsheet document: " + GetDocumentName());
            // Additional logic for spreadsheet document processing
        }

        public void PerformDataAnalysis()
        {
            Console.WriteLine("Performing data analysis on the spreadsheet.");
        }
    }
}