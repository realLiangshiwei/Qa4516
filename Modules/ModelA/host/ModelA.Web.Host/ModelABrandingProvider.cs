using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ModelA;

[Dependency(ReplaceServices = true)]
public class ModelABrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ModelA";
}
