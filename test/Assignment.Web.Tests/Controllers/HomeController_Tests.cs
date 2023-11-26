using System.Threading.Tasks;
using Assignment.Models.TokenAuth;
using Assignment.Web.Controllers;
using Shouldly;
using Xunit;

namespace Assignment.Web.Tests.Controllers
{
    public class HomeController_Tests: AssignmentWebTestBase
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