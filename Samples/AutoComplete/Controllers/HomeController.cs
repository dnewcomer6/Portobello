using System.Web.Mvc;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Query(string queryCode)
        {
            if (queryCode.StartsWith("t-"))
                return RedirectToAction("talk", new { id = queryCode.Replace("t-", "") });
            if (queryCode.StartsWith("c-"))
                return RedirectToAction("conf", new { id = queryCode.Replace("c-", "") });
            return View("index");
        }
    }
}