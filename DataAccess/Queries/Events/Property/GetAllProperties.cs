using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecDash.DataAccess.Queries.Events.Property
{
    public class GetAllProperties : IQuery<IEnumerable<PropertyResult>>
    {
        private const string sql = @"SELECT Property_Code as PropertyCode
                                            ,Ext_Ref_Property_Id as PropertyId
                                            ,Addr1 as PropertyName
                                            ,Addr1 as Address1
                                            ,City as City
                                            ,State as State
                                            ,ZipCode as ZipCode
                                            ,Country as Country
                                            ,Notes as Notes                                    
                                    FROM [dbo].[Property]";

        public IEnumerable<PropertyResult> Execute(IDbQueryContext dbContext)
        {
            return dbContext.Query<PropertyResult>(sql);
        }
    }
}
