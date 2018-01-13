using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeetingProgram.Models;
using MeetingProgram.Models.MeetingModel;

namespace MeetingProgram.Controllers
{
    public class AgendaController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_AgendaCreate");
        }

        [HttpPost]
        public ActionResult Create([Bind] Agenda agenda)
        {
            return View(agenda);
        }

        public ActionResult ViewCreateAgenda()
        {
            var agenda = new Agenda();
            agenda.Topics.Add(new Topic());


            return PartialView("_AgendaCreate", agenda);
        }


        [HttpPost]
        public ActionResult CreateAgenda([Bind] Agenda agenda)
        {
            return View();
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult AddTopic()
        {
            var agenda = new Agenda();
            agenda.Topics.Add(new Topic());

            return View(agenda);
        }


    }
}
