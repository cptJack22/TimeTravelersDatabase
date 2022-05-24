using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data;
using TimeTravelersDatabase.Services;

namespace TimeTravelersDatabase
{
	public class Startup
	{
		private readonly IConfiguration _config;
		private readonly IWebHostEnvironment _env;

		public Startup(IConfiguration config, IWebHostEnvironment env)
		{
			_config = config;
			_env = env;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			///	TODO
			///	add identity
			///	add entity famework arrival windows
			///	add authentication - cookie, jwtbearer
			///	add db context

			services.AddTransient<IMailService, NullMailService>();

			//	db context

			//	db seeder
			services.AddTransient<TTDbSeeder>();

			//	automapper
			//services.AddAutoMapper(Assembly.GetExecutingAssembly());

			//	repositories
			if (_env.IsDevelopment())
			{

			}
			else
			{

			}

			//	controllers
			services.AddControllersWithViews()
				.AddRazorRuntimeCompilation()
				.AddNewtonsoftJson(cfg => cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

			services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// Add Error Page
				app.UseExceptionHandler("/error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			///	TODO
			///	UseAuthentication();
			///	UseAuthorization();

			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapGet("/", async context =>
			//	{
			//		await context.Response.WriteAsync("Hello World!");
			//	});
			//});

			app.UseEndpoints(cfg =>
			{
				cfg.MapControllerRoute("Fallback",
					"{controller}/{action}/{id?}",
					new { Controller = "App", action = "Index" });

				cfg.MapRazorPages();
			});
		}
	}
}
