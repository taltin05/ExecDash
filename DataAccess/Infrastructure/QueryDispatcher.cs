using System;
using ExecDash.DataAccess.Queries.Interfaces;
using Unity;

namespace ExecDash.DataAccess.Infrastructure
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IUnityContainer container;
        public QueryDispatcher(IUnityContainer unityContainer)
        {
            this.container = unityContainer;
        }

        public TResult Dispatch<TParameter, TResult>(TParameter query)
            where TParameter : IQuery<TResult>
            where TResult : class
        {

            var handler = this.container.Resolve(typeof(IQueryHandler<TParameter, TResult>)) as IQueryHandler<TParameter, TResult>;

            if (handler == null)
            {
                throw new InvalidOperationException($"IoC Container mapping issue for type { typeof(IQueryHandler<TParameter, TResult>).ToString() }");
            }

            return handler.Execute(query);
        }
    }
}
