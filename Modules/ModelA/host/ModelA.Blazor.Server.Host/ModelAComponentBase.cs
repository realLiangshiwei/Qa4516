using ModelA.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ModelA.Blazor.Server.Host;

public abstract class ModelAComponentBase : AbpComponentBase
{
    protected ModelAComponentBase()
    {
        LocalizationResource = typeof(ModelAResource);
    }
}
