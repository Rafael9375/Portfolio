using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfolio.MVC.Startup))]
namespace Portfolio.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
