using ModelA.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ModelA;

public abstract class ModelAController : AbpControllerBase
{
    protected ModelAController()
    {
        LocalizationResource = typeof(ModelAResource);
    }
}
