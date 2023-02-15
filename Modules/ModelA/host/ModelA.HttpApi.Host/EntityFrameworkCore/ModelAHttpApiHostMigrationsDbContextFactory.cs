using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ModelA.EntityFrameworkCore;

public class ModelAHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModelAHttpApiHostMigrationsDbContext>
{
    public ModelAHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModelAHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ModelA"));

        return new ModelAHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
