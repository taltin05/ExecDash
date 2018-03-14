namespace ExecDash.DataAccess.Queries.Interfaces
{
    public interface IQuery<out T>
    {
        T Execute(IDbQueryContext dbContext);
    }
}
