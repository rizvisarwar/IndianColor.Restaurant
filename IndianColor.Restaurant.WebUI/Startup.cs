using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndianColor.Restaurant.Startup))]
namespace IndianColor.Restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
