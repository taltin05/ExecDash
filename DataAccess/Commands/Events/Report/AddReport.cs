using ExecDash.DataAccess.Commands.Interfaces;
using ExecDash.DomainModel.Models;

namespace ExecDash.DataAccess.Commands.Events.Report
{
    public class AddReport : ICommand
    {
        private const string sql = @"";

        private readonly ProductReport productReport;

        public AddReport(ProductReport productReport)
        {
            this.productReport = productReport;
        }

        public long Execute(IDbCommandContext context)
        {
            return context.Execute(sql, this.productReport);
        }

    }
}






