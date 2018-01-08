using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpSimpleCRUD.Configuration;

namespace AbpSimpleCRUD.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpSimpleCRUDWebCoreModule))]
    public class AbpSimpleCRUDWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpSimpleCRUDWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpSimpleCRUDWebHostModule).GetAssembly());
        }
    }
}
