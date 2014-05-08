using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RajeshGitWebSite.Startup))]
namespace RajeshGitWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
