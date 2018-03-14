namespace ExecDash.DataAccess.Queries.Interfaces
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TParameter, TResult>(TParameter query) 
            where TParameter : IQuery<TResult>
                where TResult : class;
    }
}