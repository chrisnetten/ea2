using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp2007_Assignment_2.Startup))]
namespace Comp2007_Assignment_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
