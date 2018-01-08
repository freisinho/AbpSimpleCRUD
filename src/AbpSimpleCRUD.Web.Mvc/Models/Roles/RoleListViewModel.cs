using System.Collections.Generic;
using AbpSimpleCRUD.Roles.Dto;

namespace AbpSimpleCRUD.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
