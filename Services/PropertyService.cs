using ExecDash.DataAccess.Commands.Interfaces;
using ExecDash.DataAccess.Queries.Events.Property;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using ExecDash.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecDash.Services
{
    public class PropertyService : IPropertyService
    {
        protected readonly IQueryDispatcher queryDispatcher;
        protected readonly ICommandDispatcher commandDispatcher;

        public PropertyService(IQueryDispatcher queryDispatcher
           , ICommandDispatcher commandDispatcher)
        {
            this.queryDispatcher = queryDispatcher;
            this.commandDispatcher = commandDispatcher;
        }

        public IEnumerable<PropertyResult> GetProperties()
        {
            IEnumerable<PropertyResult> menu = queryDispatcher
                                           .Dispatch<GetAllProperties, IEnumerable<PropertyResult>>
                                            (new GetAllProperties());
            return menu;
        }
    }
}
