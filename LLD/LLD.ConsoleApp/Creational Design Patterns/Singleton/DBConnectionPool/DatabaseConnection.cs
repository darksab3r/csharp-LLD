namespace LLD.ConsoleApp.Singleton.DBConnectionPool
{
    public class DatabaseConnection
    {
        public string ConnectionId { get; }

        public bool IsAvailable { get; set; } = true;

        public DatabaseConnection(string connectionId)
        {
            ConnectionId = connectionId;
        }

        public void Connect()
        {
            System.Console.WriteLine($"Connecting using {ConnectionId}");
        }

        public void Disconnect()
        {
            System.Console.WriteLine($"Disconnecting {ConnectionId}");
        }
    }
}