using System.Threading.Tasks;
using Geor.CountriesAPI.Configuration.Dto;

namespace Geor.CountriesAPI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
