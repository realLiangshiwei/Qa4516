using Mainapp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mainapp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MainappPageModel : AbpPageModel
{
    protected MainappPageModel()
    {
        LocalizationResourceType = typeof(MainappResource);
    }
}
