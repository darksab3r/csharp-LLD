namespace LLD.ConsoleApp.Prototype.InvoiceManager
{
    public class Invoice: IClonableObject<Invoice>
    {
        private string customerName;
        private double amount;
        private string dueDate;
        private InvoiceType type;

        public Invoice(string customerName, double amount, string dueDate, InvoiceType type)
        {
            this.customerName = customerName;
            this.amount = amount;
            this.dueDate = dueDate;
            this.type = type;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public double GetAmount()
        {
            return amount;
        }

        public string GetDueDate()
        {
            return dueDate;
        }

        public InvoiceType GetType()
        {
            return type;
        }

        public Invoice CloneObject()
        {
            // TODO: Implement clone logic
            return null;
        }
    }
}