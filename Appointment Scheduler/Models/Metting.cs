using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointment_Scheduler.Models
{
    public class Metting
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime_Start { get; set; }
        public string Start_Hours { get; set; }
        public string End_Hours { get; set; }
    }
}