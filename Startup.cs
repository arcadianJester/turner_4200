using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(turner_4200.Startup))]
namespace turner_4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
