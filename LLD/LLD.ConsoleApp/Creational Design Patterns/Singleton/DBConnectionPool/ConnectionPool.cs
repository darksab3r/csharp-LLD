using System.Collections.Generic;

namespace LLD.ConsoleApp.Singleton.DBConnectionPool
{
    public class ConnectionPool : IConnectionPool
    {
        // TODO:
        // Add:
        // - Singleton instance
        // - Private constructor
        // - Connection storage
        // - Pool initialization logic
        private static ConnectionPool _instance;
        private int _activeConnectionsCount = 0;
        private int _maxConeectionsCount;
        private static Dictionary<string,DatabaseConnection> _connections;
        private static object _lock = new object();
        
        private ConnectionPool()
        {
            
        }
        
        public static ConnectionPool GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ConnectionPool();
                }
            }
            return _instance;
        }

        public void InitializePool(int maxConnections)
        {
            _maxConeectionsCount = maxConnections;
            _connections = new Dictionary<string, DatabaseConnection>();
            for(int i = 0; i < maxConnections; i++)
            {
                _connections.Add($"DbConnection{i}",new DatabaseConnection($"DbConnection{i}"));
            }
        }

        public DatabaseConnection GetConnection()
        {
            foreach(var connection in _connections.Values)
            {
                if(connection.IsAvailable)
                {
                    connection.IsAvailable = false;
                    _activeConnectionsCount++;
                    return connection;
                }
            }
            return null;
        }

        public void ReleaseConnection(DatabaseConnection connection)
        {
            _connections[connection.ConnectionId].IsAvailable = true;
            _activeConnectionsCount--;
        }

        public int GetActiveConnectionCount()
        {
            return _activeConnectionsCount;
        }

        public int GetTotalConnectionCount()
        {
            return _maxConeectionsCount;
        }

        public void ResetInstance()
        {
            _connections = null;
        }
    }
}