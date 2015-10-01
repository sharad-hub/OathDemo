using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IdentitySample
{
    // Note: For instructions on enabling IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=301868
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalHost.Configuration.ConnectionTimeout = TimeSpan.FromSeconds(110);
            //// Wait a maximum of 30 seconds after a transport connection is lost
            //// before raising the Disconnected event to terminate the SignalR connection.
            //GlobalHost.Configuration.DisconnectTimeout = TimeSpan.FromSeconds(30);
            //// For transports other than long polling, send a keepalive packet every
            //// 10 seconds. 
            //// This value must be no more than 1/3 of the DisconnectTimeout value.
            //GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(10);
           // RouteTable.Routes.MapHubs();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
