using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PucIeee.Startup))]
namespace PucIeee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
