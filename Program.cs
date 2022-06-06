using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RoleBasedAuthorization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
            webBuilder.ConfigureKestrel(serverOptions =>
            {
                // Set properties and call methods on options
                serverOptions.Limits.MaxConcurrentConnections = 8000;
                serverOptions.Limits.MaxConcurrentUpgradedConnections = 8000;
                serverOptions.Limits.Http2.MaxStreamsPerConnection = 8000;

            })
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>();
        });

    }
}
