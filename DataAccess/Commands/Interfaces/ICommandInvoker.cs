using System.Collections.Generic;

namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface ICommandInvoker
    {
        long Invoke(ICommand command);

        long Invoke(IList<ICommand> commands);
    }    
}

