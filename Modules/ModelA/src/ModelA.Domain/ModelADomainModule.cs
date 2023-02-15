using Volo.Abp.Domain;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace ModelA;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModelADomainSharedModule),
    typeof(AbpIdentityDomainModule)
)]
public class ModelADomainModule : AbpModule
{

}
