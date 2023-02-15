using Mainapp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mainapp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MainappController : AbpControllerBase
{
    protected MainappController()
    {
        LocalizationResource = typeof(MainappResource);
    }
}
