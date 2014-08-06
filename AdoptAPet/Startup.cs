using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdoptAPet.Startup))]
namespace AdoptAPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
