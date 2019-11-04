using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace JeopicodusAPI.Models
{
    public class JeopicodusAPIContextFactory : IDesignTimeDbContextFactory<JeopicodusAPIContext>
    {

        JeopicodusAPIContext IDesignTimeDbContextFactory<JeopicodusAPIContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<JeopicodusAPIContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new JeopicodusAPIContext(builder.Options);
        }
    }
}