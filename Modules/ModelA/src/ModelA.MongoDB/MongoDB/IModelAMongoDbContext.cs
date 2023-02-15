using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModelA.MongoDB;

[ConnectionStringName(ModelADbProperties.ConnectionStringName)]
public interface IModelAMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
