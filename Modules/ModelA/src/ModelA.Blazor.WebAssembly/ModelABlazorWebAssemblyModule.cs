using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace ModelA.Blazor.WebAssembly;

[DependsOn(
    typeof(ModelABlazorModule),
    typeof(ModelAHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ModelABlazorWebAssemblyModule : AbpModule
{

}
