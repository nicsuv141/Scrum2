using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Scrum2.Controllers
{
    [AllowAnonymous]
    public class InFormalBlogController : Controller
    {
        // GET: InFormalBlog
        public ActionResult Index()
        {
            return View();
        }
    }
}