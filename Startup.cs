using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PharmacyOnline.Startup))]
namespace PharmacyOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
