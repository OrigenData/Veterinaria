using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeterinariaWeb.Startup))]
namespace VeterinariaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
