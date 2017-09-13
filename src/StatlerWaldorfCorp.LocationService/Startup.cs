using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StatlerWaldorfCorp.LocationService.Persistence;

namespace StatlerWaldorfCorp.LocationService
{

    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {

        }

        public IConfigurationRoot Configuration { get; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<ILocationRecordRepository, MemoryLocationRecordRepository>();
        }

    }
}