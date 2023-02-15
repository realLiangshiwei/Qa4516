using Mainapp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mainapp.Permissions;

public class MainappPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MainappPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MainappPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MainappResource>(name);
    }
}
