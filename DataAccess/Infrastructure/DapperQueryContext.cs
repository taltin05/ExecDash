using System.Collections.Generic;
using System.Data;
using Dapper;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DataAccess.Core;

namespace ExecDash.DataAccess.Infrastructure
{
    public class DapperQueryContext : IDbQueryContext
    {
        protected readonly IConnectionFactory connectionFactory;

        public DapperQueryContext(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public IDbConnection Connection
        {
            get
            {
                IDbConnection dbConnection = this.connectionFactory.GetConnection();

                if (string.IsNullOrWhiteSpace(dbConnection.ConnectionString))
                    dbConnection.ConnectionString = connectionFactory.ConnectionString;

                return dbConnection;
            }

        }

        public IEnumerable<T> Query<T>(string query, object param = null, CommandType commandType = CommandType.Text)
        {
            using (IDbConnection conn = this.Connection)
            {
                conn.Open();

                return conn.Query<T>(query, param, commandType: commandType);
            }
        }

    }
}