using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace RQCore.Authorization
{
    public class RQCoreAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);

            if (pages == null)
                pages = context.CreatePermission(PermissionNames.Pages, L(PermissionNames.Pages));


            context.CreatePermission(PermissionNames.Pages_Users, L(PermissionNames.Pages_Users));
            context.CreatePermission(PermissionNames.Pages_Roles, L(PermissionNames.Pages_Roles));
            context.CreatePermission(PermissionNames.Pages_Tenants, L(PermissionNames.Pages_Tenants), multiTenancySides: MultiTenancySides.Host);



            var Pages_Staff = pages.CreateChildPermission(PermissionNames.Pages_Staff, L(PermissionNames.Pages_Staff));
            
            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Merchandiser, L(PermissionNames.Pages_Staff_Merchandiser));
            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Customer_service, L(PermissionNames.Pages_Staff_Customer_service)); 
            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Financial, L(PermissionNames.Pages_Staff_Financial));



            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Owner, L(PermissionNames.Pages_Staff_Owner));

            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Staff_Others, L(PermissionNames.Pages_Staff_Others));


            //Inspection

            Pages_Staff.CreateChildPermission(PermissionNames.Pages_Inspection, L(PermissionNames.Pages_Inspection));


            var Pages_Admin = Pages_Staff.CreateChildPermission(PermissionNames.Pages_Admin, L(PermissionNames.Pages_Admin));
                Pages_Admin.CreateChildPermission(PermissionNames.Pages_Admin_Users, L(PermissionNames.Pages_Admin_Users));
                Pages_Admin.CreateChildPermission(PermissionNames.Pages_Admin_Roles, L(PermissionNames.Pages_Admin_Roles));

            var RQAssitant= Pages_Staff.CreateChildPermission(PermissionNames.Pages_RQAssitant, L(PermissionNames.Pages_RQAssitant));
                RQAssitant.CreateChildPermission(PermissionNames.Pages_RQAssitant_Users, L(PermissionNames.Pages_RQAssitant_Users));
                RQAssitant.CreateChildPermission(PermissionNames.Pages_RQAssitant_Roles, L(PermissionNames.Pages_RQAssitant_Roles));

            var tasks = pages.CreateChildPermission(PermissionNames.Pages_Tasks, L(PermissionNames.Pages_Tasks));
            tasks.CreateChildPermission(PermissionNames.Pages_Tasks_AssignPerson, L(PermissionNames.Pages_Tasks_AssignPerson));
            tasks.CreateChildPermission(PermissionNames.Pages_Tasks_Delete, L(PermissionNames.Pages_Tasks_Delete));
            //tasks.CreateChildPermission(PermissionNames.Pages_Tasks_Delete, L("DeleteTask"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, RQCoreConsts.LocalizationSourceName);
        }
    }
}
