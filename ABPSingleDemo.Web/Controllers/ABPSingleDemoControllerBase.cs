using Abp.Web.Mvc.Controllers;

namespace ABPSingleDemo.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ABPSingleDemoControllerBase : AbpController
    {
        protected ABPSingleDemoControllerBase()
        {
            LocalizationSourceName = ABPSingleDemoConsts.LocalizationSourceName;
        }
    }
}