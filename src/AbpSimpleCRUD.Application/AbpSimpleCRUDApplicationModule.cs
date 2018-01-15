using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpSimpleCRUD.Authorization;
using AbpSimpleCRUD.Clients.Dtos;
using AbpSimpleCRUD.Domain.Clients;

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

            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateClientInput, Client>()
                .ConstructUsing(x => new Client(x.FirstName, x.LastName))
                .AfterMap((src, dest) => dest.AddAge(src.Age));

                config.CreateMap<UpdateClientInput, Client>()
                .ConstructUsing(x => new Client(x.FirstName, x.LastName))
                .AfterMap((src, dest) => dest.AddAge(src.Age));
            });
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
