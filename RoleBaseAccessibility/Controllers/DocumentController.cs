using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBaseAccessibility.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        [AllowAnonymous]
        public ActionResult PublicDocs()
        {
            return View();
        }

        [Authorize]
        public ActionResult PrivateDocs()
        {
            return View();
        }

        [Authorize(Roles = "Admin,User,UserLevel2")]
        public ActionResult ConfidentialDocs()
        {
            return View();
        }

        [Authorize(Roles = "Admin,UserLevel3")]
        public ActionResult SystemDocs()
        {
            return View();
        }
    }
}