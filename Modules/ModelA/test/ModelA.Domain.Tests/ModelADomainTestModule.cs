using ModelA.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ModelA;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ModelAEntityFrameworkCoreTestModule)
    )]
public class ModelADomainTestModule : AbpModule
{

}
