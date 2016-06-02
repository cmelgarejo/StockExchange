using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StockExchangeTicker.Startup))]
namespace StockExchangeTicker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
