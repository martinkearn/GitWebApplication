using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWebApplication.Startup))]
namespace GitWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
