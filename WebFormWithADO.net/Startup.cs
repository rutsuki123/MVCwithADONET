using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormWithADO.net.Startup))]
namespace WebFormWithADO.net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
