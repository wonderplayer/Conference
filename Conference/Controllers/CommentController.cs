using Conference.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class CommentController : Controller
    {
        ConferenceContext context = new ConferenceContext();
        
        public PartialViewResult _GetForSession(int sessionID)
        {
            ViewBag.SessionID = sessionID;
            List<Comment> comments = context.Comments.Where(c => c.SessionID == sessionID).ToList();

            return PartialView("_GetForSession", comments);
        } 

        [ChildActionOnly]
        public PartialViewResult _CommentForm(int sessionID)
        {
            Comment comment = new Comment() { SessionID = sessionID };
            return PartialView("_CommentForm", comment);

        }

        [ValidateAntiForgeryToken]
        public PartialViewResult _Submit(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();

            List<Comment> comments = context.Comments.Where(c => c.SessionID == comment.SessionID).ToList();
            ViewBag.SessionID = comment.SessionID;

            return PartialView("_GetForSession", comments);
        }
        
    }
}