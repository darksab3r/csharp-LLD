namespace LLD.ConsoleApp.Singleton.DBConnectionPool
{
    public class DBConnectionPoolClient
    {
        public static void Run()
        {
            ConnectionPool pool = ConnectionPool.GetInstance();
            pool.InitializePool(5);
            var connection = pool.GetConnection();

            if (connection != null)
            {
                connection.Connect();
                Console.WriteLine(pool.GetTotalConnectionCount()-pool.GetActiveConnectionCount());
                connection.Disconnect();
                pool.ReleaseConnection(connection);
                Console.WriteLine(pool.GetTotalConnectionCount()-pool.GetActiveConnectionCount());
            }
        }
    }
}