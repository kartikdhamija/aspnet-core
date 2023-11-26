using Abp.Authorization;
using Assignment.Authorization.Roles;
using Assignment.Authorization.Users;

namespace Assignment.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
