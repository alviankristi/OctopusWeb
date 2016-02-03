using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusWeb.Startup))]
namespace OctopusWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
