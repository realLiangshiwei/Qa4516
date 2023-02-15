using ModelA.Localization;
using Volo.Abp.Application.Services;

namespace ModelA;

public abstract class ModelAAppService : ApplicationService
{
    protected ModelAAppService()
    {
        LocalizationResource = typeof(ModelAResource);
        ObjectMapperContext = typeof(ModelAApplicationModule);
    }
}
