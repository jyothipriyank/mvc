using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvCApplication.Startup))]
namespace MyMvCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
