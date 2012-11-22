using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hosting.AspNet;
using System;
using System.Configuration;

[assembly: PreApplicationStartMethod(typeof(WebApplication1.RegisterHubs), "Start")]

namespace WebApplication1
{
    public static class RegisterHubs
    {
        public static void Start()
        {
            // Register the default hubs route: ~/signalr/hubs
            RouteTable.Routes.MapHubs();
            string server = ConfigurationManager.AppSettings["redis.server"];
            string port = ConfigurationManager.AppSettings["redis.port"];
            string password = ConfigurationManager.AppSettings["redis.password"];

            GlobalHost.DependencyResolver.UseRedis(server, Int32.Parse(port), password, new[] { "ChatSignalRSample" });
        }
    }
}
