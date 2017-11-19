using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcuseHelper.Startup))]
namespace ExcuseHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
