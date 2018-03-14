using ExecDash.DataAccess.Queries.Events.Menu;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using System.Collections.Generic;

namespace ExecDash.DataAccess.Queries.Handlers
{
    public class MenuQueryHandler
       : IQueryHandler<GetMenuByRole, IEnumerable<MenuResult>>
    {
        private readonly IQueryInvoker query;

        public MenuQueryHandler(IQueryInvoker queryInvoker)
        {
            this.query = queryInvoker;
        }

        public IEnumerable<MenuResult> Execute(GetMenuByRole queryCommand)
        {
            return this.query.Query<IEnumerable<MenuResult>>(queryCommand);
        }               
    }
}
