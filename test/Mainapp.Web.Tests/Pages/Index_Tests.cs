using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mainapp.Pages;

public class Index_Tests : MainappWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
