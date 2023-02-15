using Mainapp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Mainapp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MainappEntityFrameworkCoreModule),
    typeof(MainappApplicationContractsModule)
    )]
public class MainappDbMigratorModule : AbpModule
{

}
