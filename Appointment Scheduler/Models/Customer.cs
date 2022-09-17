using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointment_Scheduler.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Schedul> Scheduls { get; set; }
        public String Name { get; set; }

    }
}