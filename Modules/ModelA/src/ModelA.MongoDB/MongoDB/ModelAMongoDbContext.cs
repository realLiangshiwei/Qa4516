using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModelA.MongoDB;

[ConnectionStringName(ModelADbProperties.ConnectionStringName)]
public class ModelAMongoDbContext : AbpMongoDbContext, IModelAMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureModelA();
    }
}
