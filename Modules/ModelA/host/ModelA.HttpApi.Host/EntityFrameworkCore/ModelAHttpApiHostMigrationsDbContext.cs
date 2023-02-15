using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ModelA.EntityFrameworkCore;

public class ModelAHttpApiHostMigrationsDbContext : AbpDbContext<ModelAHttpApiHostMigrationsDbContext>
{
    public ModelAHttpApiHostMigrationsDbContext(DbContextOptions<ModelAHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureModelA();
    }
}
