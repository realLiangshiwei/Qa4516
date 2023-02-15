using System.Threading.Tasks;

namespace Mainapp.Data;

public interface IMainappDbSchemaMigrator
{
    Task MigrateAsync();
}
