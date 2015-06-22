using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kairos.MVC.Startup))]
namespace Kairos.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
