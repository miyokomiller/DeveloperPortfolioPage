using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEVSITE.Startup))]
namespace DEVSITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
