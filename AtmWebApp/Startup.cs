using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtmWebApp.Startup))]
namespace AtmWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
