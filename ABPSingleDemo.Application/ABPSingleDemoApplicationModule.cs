using System.Reflection;
using Abp.Modules;

namespace ABPSingleDemo
{
    [DependsOn(typeof(ABPSingleDemoCoreModule))]
    public class ABPSingleDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
