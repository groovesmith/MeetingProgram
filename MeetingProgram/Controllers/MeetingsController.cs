using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeetingProgram.Models;
using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Models.PersonModel;

namespace MeetingProgram.Controllers
{
    public class MeetingsController : Controller
    {
        private MeetingDbContext db = new MeetingDbContext();

        // GET: Meetings
        public ActionResult Index()
        {
            return View(db.Meetings.ToList());
        }

        // GET: Meetings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // GET: Meetings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingID,Date,Description,Agenda,IsDraft")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                meeting.Agenda = new Agenda();
                meeting.Agenda.Topics = new List<Topic>();
                meeting.Atendees = new List<Person>();
                db.Meetings.Add(meeting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);


            if (meeting == null)
            {
                return HttpNotFound();
            }

            ViewBag.People = db.Users.Select(x => new SelectListItem { Value = x.PersonID.ToString(), Text = x.UserName });
            return View(meeting);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingID,Date,Description,Agenda,IsDraft,Atendees.PersonID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                Meeting m = db.Meetings.Find(meeting.MeetingID);
                m.Agenda.Topics.Clear();
                foreach (Topic t in meeting.Agenda.Topics)
                {
                    m.Agenda.Topics.Add(t);
                }
                m.Date = meeting.Date;
                m.Description = meeting.Description;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.People = db.Users.Select(x => new SelectListItem { Value = x.PersonID.ToString(), Text = x.FirstName });
            return View(meeting);
        }


        // GET: Meetings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = db.Meetings.Find(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Meeting meeting = db.Meetings.Find(id);
            db.Meetings.Remove(meeting);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //public ActionResult ViewCreateAgenda()
        //{
        //    return PartialView("_AgendaCreate");
        //}

        //[HttpPost]
        //public ActionResult CreateAgenda()
        //{
        //    return RedirectToAction("Create");
        //}
        public ActionResult TopicRow()
        {
            return PartialView("TopicEditor");
        }


        //private void PopulateTopicsList()
        //{
        //    var topicsQuery = from d in db.Topics
        //                           orderby d.Index
        //                           select d;
        //    ViewBag.TopicID = new SelectList(topicsQuery);
        //}



    }
}
