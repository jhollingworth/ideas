using System.Web.Mvc;
using Ideas.Core.Helpers;

namespace Ideas.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = App.CurrentUser;

            return View();
        }
    }
}
