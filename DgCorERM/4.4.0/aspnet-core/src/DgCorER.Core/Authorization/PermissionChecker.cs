using Abp.Authorization;
using DgCorER.Authorization.Roles;
using DgCorER.Authorization.Users;

namespace DgCorER.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
