using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Geor.CountriesAPI.EntityFrameworkCore;
using Geor.CountriesAPI.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Geor.CountriesAPI.Web.Tests
{
    [DependsOn(
        typeof(CountriesAPIWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CountriesAPIWebTestModule : AbpModule
    {
        public CountriesAPIWebTestModule(CountriesAPIEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CountriesAPIWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CountriesAPIWebMvcModule).Assembly);
        }
    }
}