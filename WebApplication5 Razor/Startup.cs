using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication5_Razor.Startup))]
namespace WebApplication5_Razor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
