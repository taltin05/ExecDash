using ExecDash.DataAccess.Commands.Interfaces;
using ExecDash.DataAccess.Commands.Events.Report;
using System;

namespace ExecDash.DataAccess.Commands.Handlers
{
    public class ReportCommandHandler
        : ICommandHandler<AddReport, long>

    {
        private readonly ICommandInvoker invoker;

        public ReportCommandHandler(ICommandInvoker invoker)
        {
            this.invoker = invoker;
        }

        public long Execute(AddReport command)
        {
            throw new NotImplementedException();
        }
    }
}