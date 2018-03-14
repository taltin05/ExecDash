using System.ComponentModel.DataAnnotations;

namespace ExecDash.DomainModel.Model
{
    public class UserCredential
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}