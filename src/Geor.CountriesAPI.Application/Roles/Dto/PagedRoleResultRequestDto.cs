using Abp.Application.Services.Dto;

namespace Geor.CountriesAPI.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

