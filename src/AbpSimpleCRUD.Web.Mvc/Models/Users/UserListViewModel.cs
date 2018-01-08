using System.Collections.Generic;
using AbpSimpleCRUD.Roles.Dto;
using AbpSimpleCRUD.Users.Dto;

namespace AbpSimpleCRUD.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
