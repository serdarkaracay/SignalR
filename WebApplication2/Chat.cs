using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Chat : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}