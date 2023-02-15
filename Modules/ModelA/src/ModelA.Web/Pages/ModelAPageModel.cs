using ModelA.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModelA.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModelAPageModel : AbpPageModel
{
    protected ModelAPageModel()
    {
        LocalizationResourceType = typeof(ModelAResource);
        ObjectMapperContext = typeof(ModelAWebModule);
    }
}
