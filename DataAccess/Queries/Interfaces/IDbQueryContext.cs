using System.Collections.Generic;
using System.Data;

namespace ExecDash.DataAccess.Queries.Interfaces
{
    public interface IDbQueryContext
    {
        IEnumerable<T> Query<T>(string query, object param = null, CommandType commandType = CommandType.Text);
    }
}
