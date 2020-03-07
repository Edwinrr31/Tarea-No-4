using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea_4.Startup))]
namespace Tarea_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
