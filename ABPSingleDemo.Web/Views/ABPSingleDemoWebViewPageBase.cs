using Abp.Web.Mvc.Views;

namespace ABPSingleDemo.Web.Views
{
    public abstract class ABPSingleDemoWebViewPageBase : ABPSingleDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPSingleDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPSingleDemoWebViewPageBase()
        {
            LocalizationSourceName = ABPSingleDemoConsts.LocalizationSourceName;
        }
    }
}