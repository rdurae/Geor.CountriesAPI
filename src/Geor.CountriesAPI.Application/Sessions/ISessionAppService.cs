using System.Threading.Tasks;
using Abp.Application.Services;
using Geor.CountriesAPI.Sessions.Dto;

namespace Geor.CountriesAPI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
