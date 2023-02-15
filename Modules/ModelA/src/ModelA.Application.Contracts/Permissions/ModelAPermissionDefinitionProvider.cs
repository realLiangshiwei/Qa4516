using ModelA.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ModelA.Permissions;

public class ModelAPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModelAPermissions.GroupName, L("Permission:ModelA"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModelAResource>(name);
    }
}
