using Abp.Application.Services;

namespace ABPSingleDemo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPSingleDemoAppServiceBase : ApplicationService
    {
        protected ABPSingleDemoAppServiceBase()
        {
            LocalizationSourceName = ABPSingleDemoConsts.LocalizationSourceName;
        }
    }
}