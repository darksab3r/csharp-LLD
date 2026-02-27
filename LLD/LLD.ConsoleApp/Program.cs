using LLD.ConsoleApp.Decorator.ApiEnhancement;
using LLD.ConsoleApp.Factory.AudioPlayerFactory;
using LLD.ConsoleApp.Factory.DocumentProcessor;
using LLD.ConsoleApp.Observer.TaskManagement;
using LLD.ConsoleApp.Prototype.ConfigurationManager;
using LLD.ConsoleApp.Prototype.InvoiceManager;
using LLD.ConsoleApp.Singleton.basic;
using LLD.ConsoleApp.Singleton.DBConnectionPool;
using LLD.ConsoleApp.Singleton.LoggerSingleton;
using LLD.ConsoleApp.Strategy.PricingManager;

namespace LLD.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        //BasicSingletonClient.Run();
        // LoggerClient.Run();
        // DBConnectionPoolClient.Run();
        
        // AudioPlayerFactoryClient.Run();
        //new DocumentProcessorClient().Run();
        
       // new ConfigurationManagerClient().Run();
       // new InvoiceManagerClient().Run();

       // new PricingManagerClient().Run();
       // new ECommerceAPIClient().Run();
       
       new TaskManagementClient().Run();
    }
}