using firstAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace firstAbp.Permissions;

public class firstAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(firstAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(firstAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<firstAbpResource>(name);
    }
}
