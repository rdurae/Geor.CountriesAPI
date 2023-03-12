using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geor.CountriesAPI.Configuration;

namespace Geor.CountriesAPI.Web.Host.Startup
{
    [DependsOn(
       typeof(CountriesAPIWebCoreModule))]
    public class CountriesAPIWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CountriesAPIWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CountriesAPIWebHostModule).GetAssembly());
        }
    }
}
