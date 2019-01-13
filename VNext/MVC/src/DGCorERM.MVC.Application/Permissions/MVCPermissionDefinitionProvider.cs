using DGCorERM.MVC.Localization.MVC;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DGCorERM.MVC.Permissions
{
    public class MVCPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MVCPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(MVCPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MVCResource>(name);
        }
    }
}
