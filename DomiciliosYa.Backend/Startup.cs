using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomiciliosYa.Backend.Startup))]
namespace DomiciliosYa.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
