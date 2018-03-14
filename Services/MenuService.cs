using ExecDash.DataAccess.Commands.Interfaces;
using ExecDash.DataAccess.Queries.Events.Menu;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using ExecDash.Services.Interfaces;
using System.Collections.Generic;

namespace ExecDash.Services
{
    public class MenuService : IMenuService
    {
        protected readonly IQueryDispatcher queryDispatcher;
        protected readonly ICommandDispatcher commandDispatcher;

        public MenuService(IQueryDispatcher queryDispatcher
           , ICommandDispatcher commandDispatcher)
        {
            this.queryDispatcher = queryDispatcher;
            this.commandDispatcher = commandDispatcher;
        }

        public IEnumerable<MenuResult> GetMenuByRole(string role)
        {
            IEnumerable<MenuResult> menu = queryDispatcher
                                           .Dispatch<GetMenuByRole, IEnumerable<MenuResult>>
                                            (new GetMenuByRole(role));
            return menu;
        }
    }
}