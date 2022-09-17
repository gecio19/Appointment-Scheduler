using Appointment_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Appointment_Scheduler.Controllers
{
    public class SchedulController : Controller
    {
        private ApplicationDbContext _contex;

        public SchedulController()
        {
            _contex = new ApplicationDbContext();
        }



        // GET: Schedul
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListOfMetting()
        {
            var Mettings = _contex.Mettings.ToList();

            return View(Mettings);
        }
    }
}