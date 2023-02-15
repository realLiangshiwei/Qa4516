using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ModelA;

[DependsOn(
    typeof(ModelAApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ModelAHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ModelAApplicationContractsModule).Assembly,
            ModelARemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModelAHttpApiClientModule>();
        });

    }
}
