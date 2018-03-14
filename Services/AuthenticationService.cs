using System;
using ExecDash.DomainModel.Dto;
using ExecDash.Services.Interfaces;

namespace ExecDash.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private UserIdentifierResult authUser;
        public UserIdentifierResult AuthenticateUser { get { return this.authUser; } }

        public string ErrorMessage { get { throw new NotImplementedException(); } }

        public bool IsCredentialAuthenticated(string username, string password)
        {
            // TODO: Mock Up code , removed with readl validation
            this.authUser = new UserIdentifierResult
            {
                Email = "bibek@gmail.com",
                Role = "Admin",
                UserID = 01234567,
                UserName = "bpandeya"
            };

            return (username.Equals("newUser") && password.Equals("test"));

        }
    }
}