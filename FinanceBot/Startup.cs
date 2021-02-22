using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceBot.Startup))]
namespace FinanceBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
