using System.Web.Mvc;
using Mvc.Ui.BootstrapMvcUi.Shared.Models;

namespace Mvc.Ui.BootstrapMvcUi.Shared.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BasicTypesEditorTemplates()
        {
            return View(new BasicTypesModel());
        }

        [HttpPost]
        public ActionResult BasicTypesEditorTemplates(BasicTypesModel model)
        {
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}