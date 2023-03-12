using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.CountriesAPI.Application
{
    public class Country : Entity
    {        
        public virtual string CountryName { get; set; }
        public virtual string CountryCode { get; set; }
    }
}
