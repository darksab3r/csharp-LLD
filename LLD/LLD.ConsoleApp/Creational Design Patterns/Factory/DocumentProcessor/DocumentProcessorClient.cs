using System;

namespace LLD.ConsoleApp.Factory.DocumentProcessor
{
    public class DocumentProcessorClient
    {
        public void Run()
        {
            DocumentProcessorFactory factory = new DocumentProcessorFactory();

            DocumentProcessor txtProcessor =
                factory.CreateProcessor(DocumentType.TEXT, "sample.txt");
            
            DocumentProcessor pptProcessor =
                factory.CreateProcessor(DocumentType.PRESENTATION, "sample.ppt");
            
            DocumentProcessor sheetProcessor =
                factory.CreateProcessor(DocumentType.SPREAD_SHEET, "sample.xls");
            
            pptProcessor.ProcessDocument();
            
            sheetProcessor.ProcessDocument();

            txtProcessor.ProcessDocument();
        }
    }
}