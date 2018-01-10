using System.Linq;
using System.Web.Mvc;
using MeetingProgram.Models;
using MeetingProgram.Models.MeetingModel;

namespace MeetingProgram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
    }
}
