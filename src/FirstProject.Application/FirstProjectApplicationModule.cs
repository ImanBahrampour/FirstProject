using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstProject.Authorization;

namespace FirstProject
{
    [DependsOn(
        typeof(FirstProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FirstProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FirstProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FirstProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
