namespace RoleBaseAccessibility.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Home controller class.
    /// </summary>
    [Authorize]
    public class HomeController : Controller
    {
        /// <summary>
        /// Index method.
        /// </summary>
        /// <returns>Returns - Index view</returns>
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Admin only link method.
        /// </summary>
        /// <returns>Returns - Admin only link view</returns>
        [Authorize(Roles = "1")]
        public ActionResult AdminOnlyLink()
        {
            return this.View();
        }
    }
}