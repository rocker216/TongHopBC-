using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TongHopBC.Startup))]
namespace TongHopBC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
