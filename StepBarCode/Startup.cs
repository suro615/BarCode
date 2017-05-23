using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StepBarCode.Startup))]
namespace StepBarCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
