using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Scrum2.Controllers
{
    [AllowAnonymous]
    public class FormalBlogController : Controller
    {
        // GET: FormalBlog
        public ActionResult FormalBlog()
        {
            return View();
        }
    }
}