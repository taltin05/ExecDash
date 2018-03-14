using System.Collections.Generic;

namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface ICommandChainHandler<in TParameter, out TResult>
         where TParameter : IList<ICommand>
    {
        TResult Execute(TParameter command);
    }    
}
