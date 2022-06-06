using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RoleBasedAuthorization.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace RoleBasedAuthorization
{
    public class UserActivityFilter : ActionFilterAttribute
    {
        MyDbContext db = new MyDbContext();
        private readonly ILogger _logger;

        public UserActivityFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("ValidatePayloadTypeFilter");
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var data = "";
        var controllerName = context.RouteData.Values["controller"];
        var actionName = context.RouteData.Values["action"];
        var url = $"{controllerName}/{actionName}";

            
        if (!string.IsNullOrEmpty(context.HttpContext.Request.QueryString.Value))
        {
            data = context.HttpContext.Request.QueryString.Value;
        }
        else
        {
            var userData = context.ActionArguments.FirstOrDefault();
            var stringUserData = JsonConvert.SerializeObject(userData);

            data = stringUserData;
        }
            
            if (!String.IsNullOrEmpty(context.HttpContext.Session.GetString("email")))
            {
                var uname = context.HttpContext.Session.GetString("email").ToString();

                var userName = uname;

                var ipAddress = GetLocalIPAddress();

                var MachineName = Environment.MachineName;

                StoreUserActivity(data, url, userName, ipAddress, MachineName);
                base.OnActionExecuting(context);
            }
            
    }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public void StoreUserActivity(string data, string url, string username, string ipaddress, string machinename)
        {
            var userActivity = new UserActivity
            {
                Data = data,
                Url = url,
                UserName = username,
                IpAddress = ipaddress,
                ClientPC = machinename
            };
            db.UserActivities.Add(userActivity);
            db.SaveChanges();
        }

    }
}
