using System.Web.Mvc;
using AutoComplete.Controllers.Services;

namespace AutoComplete.Controllers
{
    public class HintController : Controller
    {
        private readonly HintService _service = new HintService();

        public ActionResult S(string query)
        {
            var hints = _service.GetHints(query);
            return Json(hints, JsonRequestBehavior.AllowGet);
        }
    }
}