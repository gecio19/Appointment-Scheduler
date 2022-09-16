using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appointment_Scheduler.Startup))]
namespace Appointment_Scheduler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
