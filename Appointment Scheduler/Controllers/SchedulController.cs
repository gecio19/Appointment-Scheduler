using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appointment_Scheduler.Controllers
{
    public class SchedulController : Controller
    {
        // GET: Schedul
        public ActionResult Index()
        {
            return View();
        }
    }
}