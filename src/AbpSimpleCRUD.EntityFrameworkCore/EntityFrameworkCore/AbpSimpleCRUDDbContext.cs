using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpSimpleCRUD.Authorization.Roles;
using AbpSimpleCRUD.Authorization.Users;
using AbpSimpleCRUD.MultiTenancy;

namespace AbpSimpleCRUD.EntityFrameworkCore
{
    public class AbpSimpleCRUDDbContext : AbpZeroDbContext<Tenant, Role, User, AbpSimpleCRUDDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpSimpleCRUDDbContext(DbContextOptions<AbpSimpleCRUDDbContext> options)
            : base(options)
        {
        }
    }
}
