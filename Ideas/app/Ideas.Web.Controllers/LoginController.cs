using System.Web.Mvc;
using RPXLib.Interfaces;

namespace Ideas.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRPXService _rpxService;

        public LoginController(IRPXService rpxService)
        {
            _rpxService = rpxService;
        }




    }
}