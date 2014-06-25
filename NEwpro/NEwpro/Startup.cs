using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NEwpro.Startup))]
namespace NEwpro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
