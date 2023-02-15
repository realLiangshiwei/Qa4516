using Mainapp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mainapp;

[DependsOn(
    typeof(MainappEntityFrameworkCoreTestModule)
    )]
public class MainappDomainTestModule : AbpModule
{

}
