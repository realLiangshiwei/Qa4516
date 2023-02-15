using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ModelA.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ModelABrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ModelA";
}
