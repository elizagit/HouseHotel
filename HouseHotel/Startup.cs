using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HouseHotel.Startup))]
namespace HouseHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
