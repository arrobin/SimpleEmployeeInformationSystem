using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleEmployeeInformationSystem.Startup))]
namespace SimpleEmployeeInformationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
