using System.Threading.Tasks;
using Geor.CountriesAPI.Models.TokenAuth;
using Geor.CountriesAPI.Web.Controllers;
using Shouldly;
using Xunit;

namespace Geor.CountriesAPI.Web.Tests.Controllers
{
    public class HomeController_Tests: CountriesAPIWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}