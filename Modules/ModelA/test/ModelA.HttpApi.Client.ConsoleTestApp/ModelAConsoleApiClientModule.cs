using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ModelA;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModelAHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ModelAConsoleApiClientModule : AbpModule
{

}
