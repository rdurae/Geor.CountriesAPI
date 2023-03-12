using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.CountriesAPI.Application.Dto
{
    [AutoMapFrom(typeof(Country))]
    public class CountryDTO : EntityDto
    {
        public string CountryName { get; set; }

        public string CountryCode { get; set; }
    }
}
