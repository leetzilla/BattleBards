using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BattleBards.Startup))]
namespace BattleBards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
