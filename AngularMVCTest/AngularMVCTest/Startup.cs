using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularMVCTest.Startup))]
namespace AngularMVCTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
