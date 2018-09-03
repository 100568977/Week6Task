using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6Task.Startup))]
namespace Week6Task
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
