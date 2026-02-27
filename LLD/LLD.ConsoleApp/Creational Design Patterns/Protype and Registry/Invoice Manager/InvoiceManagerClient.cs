using System;

namespace LLD.ConsoleApp.Prototype.InvoiceManager
{
    public class InvoiceManagerClient
    {
        public void Run()
        {
            Console.WriteLine("InvoiceManager Client Started");

            Invoice basicInvoice = new Invoice(
                "Customer A",
                1000,
                "2026-03-01",
                InvoiceType.BASIC
            );

            Invoice premiumInvoice = new Invoice(
                "Customer B",
                5000,
                "2026-03-15",
                InvoiceType.PREMIUM
            );

            // Test existing methods
            Console.WriteLine("Customer: " + basicInvoice.GetCustomerName());
            Console.WriteLine("Amount: " + basicInvoice.GetAmount());
            Console.WriteLine("Due Date: " + basicInvoice.GetDueDate());
            Console.WriteLine("Type: " + basicInvoice.GetType());

            Console.WriteLine("Customer: " + premiumInvoice.GetCustomerName());
            Console.WriteLine("Amount: " + premiumInvoice.GetAmount());
            Console.WriteLine("Due Date: " + premiumInvoice.GetDueDate());
            Console.WriteLine("Type: " + premiumInvoice.GetType());

            InvoicePrototypeRegistry registry = new InvoicePrototypeRegistry();

            // TODO: AddPrototype logic not implemented
            registry.AddPrototype(basicInvoice);

            // TODO: GetPrototype logic not implemented
            Invoice cloned = registry.GetPrototype(InvoiceType.BASIC);

            if (cloned != null)
            {
                Console.WriteLine("Cloned Customer: " + cloned.GetCustomerName());
            }
        }
    }
}