using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModelA.EntityFrameworkCore;

[ConnectionStringName(ModelADbProperties.ConnectionStringName)]
public class ModelADbContext : AbpDbContext<ModelADbContext>, IModelADbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ModelADbContext(DbContextOptions<ModelADbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureModelA();
    }
}
