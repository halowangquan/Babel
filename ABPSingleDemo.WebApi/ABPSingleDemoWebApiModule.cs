using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace ABPSingleDemo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ABPSingleDemoApplicationModule))]
    public class ABPSingleDemoWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ABPSingleDemoApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
