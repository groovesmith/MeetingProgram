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
            MeetingDbContext context = new MeetingDbContext();

            Meeting meeting = context.Meetings.SingleOrDefault(x => x.IsDraft == false);

            meeting.AddTopictoAgenda("Test");

            context.SaveChanges();

            return View();
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
    }
}
