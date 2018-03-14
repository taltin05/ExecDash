namespace ExecDash.DataAccess.Commands.Interfaces
{
    public interface ICommand
    {
        long Execute(IDbCommandContext context);        
    }
}
