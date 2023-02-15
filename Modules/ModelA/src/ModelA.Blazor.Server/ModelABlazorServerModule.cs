using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace ModelA.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ModelABlazorModule)
    )]
public class ModelABlazorServerModule : AbpModule
{

}
