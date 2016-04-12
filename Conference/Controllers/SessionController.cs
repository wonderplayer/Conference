using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            ConferenceContext context = new ConferenceContext();
            List<Session> sessions = context.Sessions.ToList();
            return View(sessions);
        }

        //GET: Session/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Session/Create
        [HttpPost]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid) {
                return View(session);
            }
            try
            {
                ConferenceContext context = new ConferenceContext();
                context.Sessions.Add(session);
                context.SaveChanges();
            } catch (Exception ex) {
                ModelState.AddModelError("Error ", ex.Message);
                return View(session);
            }

            TempData["Message"] = "Created " + session.Title;

            return RedirectToAction("Index");
        }
    }
}