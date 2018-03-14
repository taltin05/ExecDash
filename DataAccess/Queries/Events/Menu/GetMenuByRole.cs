using System.Collections.Generic;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;

namespace ExecDash.DataAccess.Queries.Events.Menu
{
    public class GetMenuByRole : IQuery<IEnumerable<MenuResult>>
    {
        private readonly string userRole;

        private const string sql = @"SELECT * FROM [dbo].[Menu] 
                                WHERE AccessRole = @AccessRole;";
        
        public GetMenuByRole(string role)
        {
            this.userRole = role;
        }              

        public IEnumerable<MenuResult> Execute(IDbQueryContext dbContext)
        {           
            return dbContext.Query<MenuResult>(sql, new { AccessRole = this.userRole });
        }
    }       
}
