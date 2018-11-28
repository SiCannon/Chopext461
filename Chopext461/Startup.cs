using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chopext461.Startup))]
namespace Chopext461
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
