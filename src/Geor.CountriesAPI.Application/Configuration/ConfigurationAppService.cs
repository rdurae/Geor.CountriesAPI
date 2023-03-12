using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Geor.CountriesAPI.Configuration.Dto;

namespace Geor.CountriesAPI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CountriesAPIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
