using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpSimpleCRUD.Configuration;
using AbpSimpleCRUD.EntityFrameworkCore;
using AbpSimpleCRUD.Migrator.DependencyInjection;

namespace AbpSimpleCRUD.Migrator
{
    [DependsOn(typeof(AbpSimpleCRUDEntityFrameworkModule))]
    public class AbpSimpleCRUDMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpSimpleCRUDMigratorModule(AbpSimpleCRUDEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AbpSimpleCRUDMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpSimpleCRUDConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpSimpleCRUDMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
