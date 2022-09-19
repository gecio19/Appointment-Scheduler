using Appointment_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Data;
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
           var Meetings = _contex.Mettings.ToList();

            foreach (var item in Meetings)
            {

            }




            var tuple = new Tuple<Metting, IEnumerable<Metting>>(new Metting(), Meetings);

            return View(tuple);
        }





        #region Navbar for AddingNewMeeting
        [HttpPost]
        public ActionResult CreateToday(Metting meeting ,  string Timestart, string TimeEnd)
        {

            meeting.DateTime_Start = DateTime.Today;

            meeting.Start_Hours = Timestart;
            meeting.End_Hours = TimeEnd;



            _contex.Mettings.Add(meeting);
            _contex.SaveChanges();
            

            return RedirectToAction("ListOfMetting", "Schedul");
        }



        [HttpPost]
        public ActionResult CreateTommorow(Metting meeting, string Timestart, string TimeEnd)
        {

            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            meeting.Start_Hours = Timestart;
            meeting.End_Hours = TimeEnd;



            meeting.DateTime_Start = tomorrow;
            _contex.Mettings.Add(meeting);
            _contex.SaveChanges();

            return RedirectToAction("ListOfMetting", "Schedul");
        }











        #endregion
    }
}