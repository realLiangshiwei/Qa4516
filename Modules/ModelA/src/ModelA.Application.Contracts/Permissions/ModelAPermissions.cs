using Volo.Abp.Reflection;

namespace ModelA.Permissions;

public class ModelAPermissions
{
    public const string GroupName = "ModelA";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModelAPermissions));
    }
}
