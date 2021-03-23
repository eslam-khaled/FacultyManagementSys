using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacultyManagementSystem.Startup))]
namespace FacultyManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
