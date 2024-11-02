using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemaFazenda2.Data
{
    public class DatabaseConnection : IDisposable
    {
        private SqlConnection connection;
        private bool disposed = false;

        public DatabaseConnection()
        {
            // Obtém a string de conexão do arquivo de configuração
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Libera os recursos gerenciados
                    connection?.Close();
                    connection?.Dispose();
                }
                disposed = true;
            }
        }

        ~DatabaseConnection()
        {
            Dispose(false);
        }
    }
}
