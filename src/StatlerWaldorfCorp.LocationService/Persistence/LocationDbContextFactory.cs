using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using StatlerWaldorfCorp.LocationService;
using StatlerWaldorfCorp.LocationService.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace StatlerWaldorfCorp.LocationService.Persistence
{
    public class LocationDbContextFactory : IDesignTimeDbContextFactory<LocationDbContext>
    {

        public LocationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<LocationDbContext>();
            var connectionString = configuration.GetSection("postgres:cstr").Value;

            optionsBuilder.UseNpgsql(connectionString);

            return new LocationDbContext(optionsBuilder.Options);
        }

    }

}