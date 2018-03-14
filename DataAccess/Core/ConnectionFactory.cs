using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ExecDash.DataAccess.Core
{
    public class ConnectionFactory : IConnectionFactory
    {

        private const string SQL_DATA_PROVIDER = "System.Data.SqlClient";

        private readonly string connString = ConfigurationManager
                                                    .ConnectionStrings["ExecDash_ConnectionString"]
                                                    .ConnectionString;
        public string ConnectionString { get { return this.connString; } }

        public ConnectionFactory() { }

        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory(SQL_DATA_PROVIDER);
            IDbConnection conn = factory.CreateConnection();
            conn.ConnectionString = connString;
            return conn;
        }
    }
}