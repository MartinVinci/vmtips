using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VmTips.Startup))]
namespace VmTips
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
