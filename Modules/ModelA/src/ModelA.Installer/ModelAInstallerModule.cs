using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ModelA;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ModelAInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModelAInstallerModule>();
        });
    }
}
