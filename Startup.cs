using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kyletest1.Startup))]
namespace kyletest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
