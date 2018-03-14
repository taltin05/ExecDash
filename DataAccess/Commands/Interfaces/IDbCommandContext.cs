using System.Data;

namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface IDbCommandContext
    {
        IDbConnection Connection { get; }

        IDbTransaction Transaction { get; set; }

        long Execute(string sql, object param);
    }
}
