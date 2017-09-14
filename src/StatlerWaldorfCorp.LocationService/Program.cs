using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace StatlerWaldorfCorp.LocationService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Startup.Args = args;
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                            .AddCommandLine(args)
                            .Build();

            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseKestrel()
                .UseConfiguration(config)
                .Build();
        }

    }
}
