using Abp.Authorization;
using AbpSimpleCRUD.Authorization.Roles;
using AbpSimpleCRUD.Authorization.Users;

namespace AbpSimpleCRUD.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
