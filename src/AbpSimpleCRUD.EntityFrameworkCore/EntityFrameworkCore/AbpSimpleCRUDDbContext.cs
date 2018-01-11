using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpSimpleCRUD.Authorization.Roles;
using AbpSimpleCRUD.Authorization.Users;
using AbpSimpleCRUD.MultiTenancy;
using AbpSimpleCRUD.Domain.Clients;

namespace AbpSimpleCRUD.EntityFrameworkCore
{
    public class AbpSimpleCRUDDbContext : AbpZeroDbContext<Tenant, Role, User, AbpSimpleCRUDDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Client> Clients { get; set; }

        public AbpSimpleCRUDDbContext(DbContextOptions<AbpSimpleCRUDDbContext> options)
            : base(options)
        {
        }
    }
}
