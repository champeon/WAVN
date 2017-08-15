using System.Web.Mvc;
using WAVN.Services;
using WAVN.Web.Models;

namespace WAVN.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICalculateService calculateService { get; set;}
        public HomeController(ICalculateService calculateService) {
            this.calculateService = calculateService;
        }

        public ActionResult Index() {

            return View();
        }

        [HttpPost]
        public JsonResult Calculate(string text) {
            var output = BuildUIOutputModel(text);
            return Json(output, JsonRequestBehavior.AllowGet);
        }

        private UIOutputModel BuildUIOutputModel(string value) {
            var result = calculateService.Calculate(value);
            return new UIOutputModel() { Result = result };
        }
    }
}