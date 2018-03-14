using System.Data;

namespace ExecDash.DataAccess.Core
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();

        string ConnectionString { get; }        
    }
}
