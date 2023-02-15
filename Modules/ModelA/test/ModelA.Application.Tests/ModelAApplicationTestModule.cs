using Volo.Abp.Modularity;

namespace ModelA;

[DependsOn(
    typeof(ModelAApplicationModule),
    typeof(ModelADomainTestModule)
    )]
public class ModelAApplicationTestModule : AbpModule
{

}
