using ExecDash.DomainModel.Dto;
using ExecDash.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExecDash.Web.WebAPI
{
    public class PropertyController : ApiController
    {
        private IPropertyService propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            this.propertyService = propertyService;
        }

        [HttpGet]
        public IEnumerable<PropertyResult> Get()
        {
            return this.propertyService.GetProperties();
        }

    }
}
