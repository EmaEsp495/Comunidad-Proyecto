using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comunidad.Startup))]
namespace Comunidad
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
