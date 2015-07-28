using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpNeed.Startup))]
namespace UpNeed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
