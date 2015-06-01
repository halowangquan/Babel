using System.Web.Mvc;

namespace ABPSingleDemo.Web.Controllers
{
    public class HomeController : ABPSingleDemoControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}