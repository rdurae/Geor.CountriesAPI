using Abp.Application.Services;
using Geor.CountriesAPI.MultiTenancy.Dto;

namespace Geor.CountriesAPI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

