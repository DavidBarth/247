using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_247.Startup))]
namespace _247
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
