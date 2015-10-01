using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace OathDemo.Hubs
{
    public class UserHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}