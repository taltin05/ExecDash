using ExecDash.DataAccess.Commands.Interfaces;
using System.Collections.Generic;
using Unity;

namespace ExecDash.DataAccess.Infrastructure
{
    public class CommandChainDispatcher : ICommandChainDispatcher
    {
        private readonly IUnityContainer unityContainer;

        public CommandChainDispatcher(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public TResult Dispatch<TParameter, TResult>(TParameter command)
            where TParameter : IList<ICommand>
        {
            var handler = this.unityContainer.Resolve<ICommandChainHandler<TParameter, TResult>>();
            return handler.Execute(command);
        }
    }
}