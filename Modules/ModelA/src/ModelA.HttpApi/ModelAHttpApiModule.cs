using Localization.Resources.AbpUi;
using ModelA.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ModelA;

[DependsOn(
    typeof(ModelAApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ModelAHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ModelAHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ModelAResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
