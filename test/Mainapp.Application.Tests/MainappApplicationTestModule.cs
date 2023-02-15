using Volo.Abp.Modularity;

namespace Mainapp;

[DependsOn(
    typeof(MainappApplicationModule),
    typeof(MainappDomainTestModule)
    )]
public class MainappApplicationTestModule : AbpModule
{

}
