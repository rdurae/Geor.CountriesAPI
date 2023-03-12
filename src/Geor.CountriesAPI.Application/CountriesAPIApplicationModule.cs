using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geor.CountriesAPI.Authorization;

namespace Geor.CountriesAPI
{
    [DependsOn(
        typeof(CountriesAPICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CountriesAPIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CountriesAPIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CountriesAPIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
