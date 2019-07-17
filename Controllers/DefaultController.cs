using System.Web.Mvc;

namespace SoftSupply.Help.Areas.GanSoftWeb.Content
{
    public class DefaultController : Controller
    {
        // GET: GanSoftWeb/Default
        public ActionResult Index(string id = "", string key = "")
        {
            if (string.IsNullOrEmpty(id))
                return View();
            else
                return View($"{id}/{key}");
        }
    }
}