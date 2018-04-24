using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeScrubberij.Startup))]
namespace DeScrubberij
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
