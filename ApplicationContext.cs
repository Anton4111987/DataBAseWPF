using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOnWPF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<VegetableAndFruit> VegetableAndFruits { get; set; } 

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            

        }

        public static DbContextOptions GetDbContextOptions(string path = "appsettings.json")
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile(path);

            var config = builder.Build();
            var connectionString = config.GetConnectionString("BloggingDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;

            return options;
        }

       
        /* public ApplicationContext()
         {
             Database.EnsureCreated();
         }*/
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=Catalog=vegetables and fruits;Trusted_Connection=True;");
         }*/


    }
}
