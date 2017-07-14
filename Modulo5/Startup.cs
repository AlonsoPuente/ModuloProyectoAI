using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modulo5.Startup))]
namespace Modulo5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
