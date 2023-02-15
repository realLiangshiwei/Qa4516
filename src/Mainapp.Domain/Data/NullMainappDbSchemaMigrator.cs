using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mainapp.Data;

/* This is used if database provider does't define
 * IMainappDbSchemaMigrator implementation.
 */
public class NullMainappDbSchemaMigrator : IMainappDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
