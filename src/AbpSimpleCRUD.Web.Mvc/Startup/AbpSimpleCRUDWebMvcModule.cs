using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpSimpleCRUD.Configuration;

namespace AbpSimpleCRUD.Web.Startup
{
    [DependsOn(typeof(AbpSimpleCRUDWebCoreModule))]
    public class AbpSimpleCRUDWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpSimpleCRUDWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AbpSimpleCRUDNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpSimpleCRUDWebMvcModule).GetAssembly());
        }
    }
}
