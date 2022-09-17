using Appointment_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Appointment_Scheduler.Controllers.Api
{
    public class SchedulController : ApiController
    {
        //żeby dostać sie do bazy danych


        private ApplicationDbContext _context;

        public SchedulController()
        {
            _context = new ApplicationDbContext();
        }





        // Get /api/customers
        public IEnumerable<Metting> GetMettings()
        {
            return _context.Mettings.ToList();


        }

        // Post /api/meeting

        [HttpPost]
        public Metting CreateMeeting(Metting meeting)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


          //Dodajemy meeting do bazy danych
            _context.Mettings.Add(meeting);
            _context.SaveChanges();
            return meeting;
        }


        //aktualizujemy dane
        [HttpPut]
        public void UpdateMeeting(int id, Metting metting)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var meetinInDb = _context.Mettings.SingleOrDefault(c => c.Id == id);

            if(meetinInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            // aktualizuje dane

            meetinInDb.DateTime_Start = metting.DateTime_Start;
            meetinInDb.DateTime_End = metting.DateTime_End;

            _context.SaveChanges();
        }


        //Delete metting
        [HttpDelete]
        public void DeleteCustomer(int id)
        {

            var meetinInDb = _context.Mettings.SingleOrDefault(c => c.Id == id);

            if (meetinInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Mettings.Remove(meetinInDb);
            _context.SaveChanges();
        }





    }
}
