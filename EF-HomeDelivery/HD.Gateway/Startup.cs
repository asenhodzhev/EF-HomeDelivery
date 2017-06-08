using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HD.Gateway.Startup))]
namespace HD.Gateway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
