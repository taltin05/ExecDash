using ExecDash.DomainModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecDash.Services.Interfaces
{
    public interface IPropertyService
    {
        IEnumerable<PropertyResult> GetProperties();

    }
}
