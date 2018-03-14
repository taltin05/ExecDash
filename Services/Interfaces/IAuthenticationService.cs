using ExecDash.DomainModel.Dto;

namespace ExecDash.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool IsCredentialAuthenticated(string username, string password);

        UserIdentifierResult AuthenticateUser { get; }

        string ErrorMessage { get; }
    }
}