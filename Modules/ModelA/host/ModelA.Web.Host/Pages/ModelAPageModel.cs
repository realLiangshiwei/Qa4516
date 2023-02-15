using ModelA.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModelA.Pages;

public abstract class ModelAPageModel : AbpPageModel
{
    protected ModelAPageModel()
    {
        LocalizationResourceType = typeof(ModelAResource);
    }
}
