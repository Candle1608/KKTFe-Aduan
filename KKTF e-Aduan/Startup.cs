using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KKTF_e_Aduan.Startup))]
namespace KKTF_e_Aduan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
