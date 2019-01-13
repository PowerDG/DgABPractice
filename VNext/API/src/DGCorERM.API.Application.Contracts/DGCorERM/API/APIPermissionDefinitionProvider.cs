using DGCorERM.API.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DGCorERM.API
{
    public class APIPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(APIPermissions.GroupName, L("Permission:API"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<APIResource>(name);
        }
    }
}