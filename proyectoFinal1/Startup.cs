using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoFinal1.Startup))]
namespace proyectoFinal1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
