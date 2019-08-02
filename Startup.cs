using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeReferalSystem.Startup))]
namespace EmployeeReferalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
