using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ULOL.Startup))]
namespace ULOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
