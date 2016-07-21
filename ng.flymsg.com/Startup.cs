using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ng.flymsg.com.Startup))]
namespace ng.flymsg.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
