using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBaseAccessibility.Startup))]
namespace RoleBaseAccessibility
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
