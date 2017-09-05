using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(WAVN.OwinStartup))]
namespace WAVN
{
    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(new HubConfiguration { EnableDetailedErrors = true });
        }
    }
}
