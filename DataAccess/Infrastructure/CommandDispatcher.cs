using Unity;
using ExecDash.DataAccess.Commands.Interfaces;

namespace ExecDash.DataAccess.Infrastructure
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IUnityContainer unityContainer;

        public CommandDispatcher(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public TResult Dispatch<TParameter, TResult>(TParameter command)
            where TParameter : ICommand
        {
            var handler = this.unityContainer.Resolve<ICommandHandler<TParameter, TResult>>();
            return handler.Execute(command);
        }

    }
        
}
