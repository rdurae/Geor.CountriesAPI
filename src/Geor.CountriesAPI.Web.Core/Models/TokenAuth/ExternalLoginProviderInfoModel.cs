using Abp.AutoMapper;
using Geor.CountriesAPI.Authentication.External;

namespace Geor.CountriesAPI.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
