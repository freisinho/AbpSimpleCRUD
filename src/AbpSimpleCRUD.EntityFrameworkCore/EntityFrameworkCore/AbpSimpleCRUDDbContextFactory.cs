using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpSimpleCRUD.Configuration;
using AbpSimpleCRUD.Web;

namespace AbpSimpleCRUD.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpSimpleCRUDDbContextFactory : IDesignTimeDbContextFactory<AbpSimpleCRUDDbContext>
    {
        public AbpSimpleCRUDDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpSimpleCRUDDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpSimpleCRUDDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpSimpleCRUDConsts.ConnectionStringName));

            return new AbpSimpleCRUDDbContext(builder.Options);
        }
    }
}
