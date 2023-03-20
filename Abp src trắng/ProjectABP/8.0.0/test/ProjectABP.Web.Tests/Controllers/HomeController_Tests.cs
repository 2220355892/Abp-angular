using System.Threading.Tasks;
using ProjectABP.Models.TokenAuth;
using ProjectABP.Web.Controllers;
using Shouldly;
using Xunit;

namespace ProjectABP.Web.Tests.Controllers
{
    public class HomeController_Tests: ProjectABPWebTestBase
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