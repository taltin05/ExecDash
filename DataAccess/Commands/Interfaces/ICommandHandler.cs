using System.Collections.Generic;

namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface ICommandHandler<in TParameter, out TResult>
         where TParameter : ICommand
    {
        TResult Execute(TParameter command);
    }

}
