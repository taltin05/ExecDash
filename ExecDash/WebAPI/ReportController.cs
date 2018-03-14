using ExecDash.DomainModel.Dto;
using ExecDash.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace ExecDash.Web.WebAPI
{
    public class MenuController : ApiController
    {
        private IMenuService reportService;
        public MenuController(IMenuService reportService)
        {
            this.reportService = reportService;
        }

        [HttpGet]
        public IEnumerable<MenuResult> Get(string role)
        {
            return this.reportService.GetMenuByRole(role);            
        }

    }
}
