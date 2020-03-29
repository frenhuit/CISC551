using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCApplication.Startup))]
namespace TestMVCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
