using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projectBlue_Dot.Startup))]
namespace projectBlue_Dot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
