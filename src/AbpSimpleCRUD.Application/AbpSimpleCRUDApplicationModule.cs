using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpSimpleCRUD.Authorization;

namespace AbpSimpleCRUD
{
    [DependsOn(
        typeof(AbpSimpleCRUDCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpSimpleCRUDApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpSimpleCRUDAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpSimpleCRUDApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
