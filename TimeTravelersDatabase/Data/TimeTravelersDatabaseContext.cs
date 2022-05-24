using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data.Entities;
using TimeTravelersDatabase.Data.Entities.News;

namespace TimeTravelersDatabase.Data
{
	public class TimeTravelersDatabaseContext : DbContext
	{
		private readonly IConfiguration _config;
		private readonly IHostingEnvironment _env;

		public TimeTravelersDatabaseContext(IConfiguration config, IHostingEnvironment env)
		{
			_config = config;
            _env = env;
		}

		public DbSet<ArrivalWindow> ArrivalWindows { get; set; }
		public DbSet<Marshaller> Marshallers { get; set; }
		public DbSet<NewsHeadline> NewsHeadlines { get; set; }
		public DbSet<WeatherReport> CurrentWeather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            base.OnConfiguring(bldr);
            if (_env.IsDevelopment())
            {
                bldr.UseInMemoryDatabase("TimeTravelersDatabase");
			}
			else
			{
 //bldr.UseSqlServer(_config.GetConnectionString("TimeTravelersDatabaseConnectionString"));
			}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserTimestamp>()
            //    .HasNoKey();

            //modelBuilder.Entity<Product>()
            //  .Property(p => p.Price)
            //  .HasColumnType("money");

            //modelBuilder.Entity<OrderItem>()
            //  .Property(o => o.UnitPrice)
            //  .HasColumnType("money");

            //modelBuilder.Entity<Order>()
            //  .HasData(new Order()
            //  {
            //      Id = 1,
            //      OrderDate = DateTime.UtcNow,
            //      OrderNumber = "12345"
            //  });
        }
    }
}
