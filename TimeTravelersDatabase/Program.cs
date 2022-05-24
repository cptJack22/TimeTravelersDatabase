using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data;

namespace TimeTravelersDatabase
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();
			
			if(args.Length>0 && args[0].ToLower()=="/seed")
			{
				RunSeeding(host);
				return;
			}
			
			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration(SetupConfiguration)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});



		private static void RunSeeding(IHost host)
		{
			var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
			using (var scope = scopeFactory.CreateScope())
			{
				///	TODO
				///	complete seed
				var seeder = scope.ServiceProvider.GetService<TTDbSeeder>();
				seeder.SeedAsync().Wait();
			}
		}

		private static void SetupConfiguration(HostBuilderContext ctx, IConfigurationBuilder builder)
		{
			// Removing the default configuration options
			builder.Sources.Clear();

			builder.AddJsonFile("appsettings.json", false, true)
				   .AddEnvironmentVariables();

		}
	}
}
