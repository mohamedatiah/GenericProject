using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullTask.Startup))]
namespace FullTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
