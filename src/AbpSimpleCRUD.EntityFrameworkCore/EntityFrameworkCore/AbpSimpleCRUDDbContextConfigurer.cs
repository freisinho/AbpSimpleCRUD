using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpSimpleCRUD.EntityFrameworkCore
{
    public static class AbpSimpleCRUDDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpSimpleCRUDDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpSimpleCRUDDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
