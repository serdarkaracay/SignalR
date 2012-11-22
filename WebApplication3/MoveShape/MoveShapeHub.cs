using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.MoveShape
{
    [HubName("moveShape")]
    public class MoveShapeHub : Hub
    {
        public void MoveShape(double x, double y)
        {
            Clients.Others.shapeMoved(x, y);
        }
    }
}