using ExecDash.DomainModel.Dto;
using System.Collections.Generic;

namespace ExecDash.Services.Interfaces
{
    public interface IMenuService
    {
       IEnumerable<MenuResult> GetMenuByRole(string role);
    }
}