namespace ExecDash.DataAccess.Queries.Interfaces
{
    public interface IQueryHandler<in TParameter, out TResult> where TParameter : IQuery<TResult>
    {
        TResult Execute(TParameter query);
    }
}
