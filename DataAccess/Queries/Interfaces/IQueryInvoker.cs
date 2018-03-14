namespace ExecDash.DataAccess.Queries.Interfaces
{
    public interface IQueryInvoker
    {
        T Query<T>(IQuery<T> query);        
    }
}
