using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualnaKnjižnica.Startup))]
namespace VirtualnaKnjižnica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
