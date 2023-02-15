using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ModelA.Pages;

public class IndexModel : ModelAPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
