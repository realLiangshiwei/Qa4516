using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ModelA.MongoDB;

public static class ModelAMongoDbContextExtensions
{
    public static void ConfigureModelA(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
