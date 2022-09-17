using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointment_Scheduler.Models
{
    public class Schedul
    {
        public int Id { get; set; }
        public List<Metting> Mettings { get; set; }
    }
}