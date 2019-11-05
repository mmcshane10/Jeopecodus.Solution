
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Jeopicodus.Models
{
    public class JeopicodusContextFactory : IDesignTimeDbContextFactory<JeopicodusContext>
    {

        JeopicodusContext IDesignTimeDbContextFactory<JeopicodusContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<JeopicodusContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new JeopicodusContext(builder.Options);
        }
    }
}