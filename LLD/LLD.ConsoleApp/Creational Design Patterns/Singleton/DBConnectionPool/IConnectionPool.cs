namespace LLD.ConsoleApp.Singleton.DBConnectionPool
{
    public interface IConnectionPool
    {
        void InitializePool(int maxConnections);
        DatabaseConnection GetConnection();
        void ReleaseConnection(DatabaseConnection connection);
        int GetActiveConnectionCount();
        int GetTotalConnectionCount();
    }
}