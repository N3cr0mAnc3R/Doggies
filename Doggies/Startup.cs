using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doggies.Startup))]
namespace Doggies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
