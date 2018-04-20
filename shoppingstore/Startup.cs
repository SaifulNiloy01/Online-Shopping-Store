using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingstore.Startup))]
namespace shoppingstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
