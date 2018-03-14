using System.Collections.Generic;

namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface ICommandDispatcher
    {
        TResult Dispatch<TParameter, TResult>(TParameter command)
           where TParameter : ICommand;
    }

    public interface ICommandChainDispatcher
    {
        TResult Dispatch<TParameter, TResult>(TParameter command)
          where TParameter : IList<ICommand>;
    }
}