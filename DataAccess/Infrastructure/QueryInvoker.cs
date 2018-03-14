using ExecDash.DataAccess.Queries.Interfaces;

namespace ExecDash.DataAccess.Infrastructure
{
    public class QueryInvoker : IQueryInvoker
    {
        private readonly IDbQueryContext dbContext;       
        public QueryInvoker(IDbQueryContext dbcontext) 
        {
            this.dbContext = dbcontext;
        }
        public T Query<T>(IQuery<T> query)
        {
            return query.Execute(this.dbContext);            
        }
    }
}

