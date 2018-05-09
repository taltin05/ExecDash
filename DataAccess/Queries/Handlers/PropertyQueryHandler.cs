using ExecDash.DataAccess.Queries.Events.Property;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecDash.DataAccess.Queries.Handlers
{
    public class PropertyQueryHandler
        : IQueryHandler<GetAllProperties, IEnumerable<PropertyResult>>
    {
        private readonly IQueryInvoker query;

        public PropertyQueryHandler(IQueryInvoker queryInvoker)
        {
            this.query = queryInvoker;
        }

        public IEnumerable<PropertyResult> Execute(GetAllProperties query)
        {
            return this.query.Query<IEnumerable<PropertyResult>>(query);
        }
    }
}
