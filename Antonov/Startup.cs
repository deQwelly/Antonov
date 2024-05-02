using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Antonov.Startup))]
namespace Antonov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
