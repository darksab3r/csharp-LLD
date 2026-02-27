namespace LLD.ConsoleApp.Prototype.InvoiceManager
{
    public class InvoicePrototypeRegistry: IInvoicePrototypeRegistry
    {
        private Dictionary<InvoiceType, Invoice> _invoicePrototypes = new Dictionary<InvoiceType, Invoice>();

        public void AddPrototype(Invoice user)
        {
            _invoicePrototypes.Add(user.GetType(), user);
        }

        public Invoice GetPrototype(InvoiceType type)
        {
            _invoicePrototypes.TryGetValue(type, out var prototype);
            return prototype;
        }

        public Invoice? Clone(InvoiceType type)
        {
            _invoicePrototypes.TryGetValue(type, out var prototype);
            return prototype?.CloneObject();
        }
    }
}