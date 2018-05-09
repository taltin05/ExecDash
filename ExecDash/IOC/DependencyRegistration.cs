using ExecDash.DataAccess.Commands.Interfaces;
using ExecDash.DataAccess.Core;
using ExecDash.DataAccess.Infrastructure;
using ExecDash.DataAccess.Queries.Events.Menu;
using ExecDash.DataAccess.Queries.Events.Property;
using ExecDash.DataAccess.Queries.Handlers;
using ExecDash.DataAccess.Queries.Interfaces;
using ExecDash.DomainModel.Dto;
using ExecDash.Services;
using ExecDash.Services.Interfaces;
using System.Collections.Generic;
using Unity;
using Unity.Injection;

namespace ExecDash.Web.IOC
{
    public class DependencyRegistration
    {
        public static void AddComponents(IUnityContainer container)
        {
            container.RegisterInstance<IConnectionFactory>(new ConnectionFactory());

            container.RegisterType<IDbCommandContext, DapperCommandContext>
                (new InjectionConstructor(
                     container.Resolve<IConnectionFactory>()
                    ));

            container.RegisterType<IDbQueryContext, DapperQueryContext>
             (new InjectionConstructor(
                  container.Resolve<IConnectionFactory>()
                 ));

            container.RegisterType<ICommandInvoker, CommandInvoker>
               (new InjectionConstructor(
                    container.Resolve<IDbCommandContext>()
                   ));

            container.RegisterType<IQueryInvoker, QueryInvoker>
               (new InjectionConstructor(
                    container.Resolve<IDbQueryContext>()
                   ));

            container.RegisterType(typeof(IQueryHandler<GetMenuByRole, IEnumerable<MenuResult>>)
                , typeof(MenuQueryHandler)
                , new InjectionConstructor(container.Resolve<IQueryInvoker>()));

            container.RegisterType(typeof(IQueryHandler<GetAllProperties, IEnumerable<PropertyResult>>)
                , typeof(PropertyQueryHandler)
                , new InjectionConstructor(container.Resolve<IQueryInvoker>()));


            container.RegisterType<IAuthenticationService, AuthenticationService>();
            container.RegisterType<IMenuService, MenuService>();
            container.RegisterType<IPropertyService, PropertyService>();

            container.RegisterType<ICommandDispatcher, CommandDispatcher>();
            container.RegisterType<IQueryDispatcher, QueryDispatcher>();
        }
    }
}