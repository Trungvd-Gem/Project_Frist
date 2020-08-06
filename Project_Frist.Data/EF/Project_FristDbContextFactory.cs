using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_Frist.Data.EF
{
    class Project_FristDbContextFactory : IDesignTimeDbContextFactory<Project_FristDbContext>
    {
        public Project_FristDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<Project_FristDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new Project_FristDbContext(optionsBuilder.Options);
        }
    }
}
