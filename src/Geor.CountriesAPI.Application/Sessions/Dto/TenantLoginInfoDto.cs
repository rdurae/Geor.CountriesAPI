using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Geor.CountriesAPI.MultiTenancy;

namespace Geor.CountriesAPI.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
