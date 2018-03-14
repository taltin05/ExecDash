using System.Data;
using Dapper;
using ExecDash.DataAccess.Core;
using ExecDash.DataAccess.Commands.Interfaces;

namespace ExecDash.DataAccess.Infrastructure
{
    public class DapperCommandContext : IDbCommandContext
    {
        private readonly IConnectionFactory connectionFactory;               

        private IDbTransaction transaction;
        public DapperCommandContext(IConnectionFactory connFactory) 
        {
            this.connectionFactory = connFactory;
        }
        public IDbConnection Connection
        {
            get
            {
                IDbConnection connection = connectionFactory.GetConnection();

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                return connection;
            }
        }
        public IDbTransaction Transaction
        {
            get { return this.transaction; }
            set { this.transaction = value; }
        }
        public long Execute(string sql, object param)
        {
            var rowAffected = this.transaction.Connection.Execute(sql, param,this.transaction);
            return rowAffected;
        }
    }
}
