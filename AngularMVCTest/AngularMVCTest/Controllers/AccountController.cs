using System.Web.Mvc;

namespace AngularMVCTest.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
    }
}