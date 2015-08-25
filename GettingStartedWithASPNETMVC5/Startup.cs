using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingStartedWithASPNETMVC5.Startup))]
namespace GettingStartedWithASPNETMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
