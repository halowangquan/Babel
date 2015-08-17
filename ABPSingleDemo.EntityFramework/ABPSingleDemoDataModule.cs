using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ABPSingleDemo.EntityFramework;

namespace ABPSingleDemo
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ABPSingleDemoCoreModule))]
    public class ABPSingleDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ABPSingleDemoDbContext>(null);
        }
    }
}
