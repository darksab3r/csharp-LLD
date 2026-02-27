using LLD.ConsoleApp.Prototype.InvoiceManager;

namespace LLD.ConsoleApp.Prototype.InvoiceManager;

public interface IInvoicePrototypeRegistry
{
    void AddPrototype(Invoice user);
    Invoice GetPrototype(InvoiceType type);
    Invoice Clone(InvoiceType type);
}