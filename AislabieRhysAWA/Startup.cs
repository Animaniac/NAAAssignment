using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AislabieRhysAWA.Startup))]
namespace AislabieRhysAWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
