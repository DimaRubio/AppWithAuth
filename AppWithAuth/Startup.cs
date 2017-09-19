using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWithAuth.Startup))]
namespace AppWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
