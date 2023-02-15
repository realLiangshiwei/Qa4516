using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModelA.EntityFrameworkCore;

[ConnectionStringName(ModelADbProperties.ConnectionStringName)]
public interface IModelADbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
