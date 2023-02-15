using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Mainapp.Web;

[Dependency(ReplaceServices = true)]
public class MainappBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Mainapp";
}
