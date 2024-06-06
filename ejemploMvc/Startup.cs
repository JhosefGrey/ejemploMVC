using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejemploMvc.Startup))]
namespace ejemploMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
