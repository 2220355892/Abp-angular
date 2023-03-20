using Abp.Authorization;
using ProjectABP.Authorization.Roles;
using ProjectABP.Authorization.Users;

namespace ProjectABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
