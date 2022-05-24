using Microsoft.AspNetCore.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public class TTDbSeeder
	{
		private readonly TimeTravelersDatabaseContext _ctx;
		private readonly IWebHostEnvironment _hosting;

		public TTDbSeeder(
			TimeTravelersDatabaseContext ctx,
			IWebHostEnvironment hosting)
		{
			_ctx = ctx;
			_hosting = hosting;
			///	TODO
			///	add userManager
		}

		/// <summary>
		/// Generate seed
		/// </summary>
		/// <returns></returns>
		public async Task SeedAsync()
		{
			_ctx.Database.EnsureCreated();

			if (!_ctx.Marshallers.Any())
			{

			}

			if (!_ctx.NewsHeadlines.Any())
			{

			}

			if (!_ctx.CurrentWeather.Any())
			{

			}

			if (!_ctx.ArrivalWindows.Any())
			{
				var arrivalWindow = new ArrivalWindow
				{
					Radius = new UnitsNet.Length(10,UnitsNet.Units.LengthUnit.Meter),
					RegionDescrption = "Park",
					PopulationDescription = "Few people. Maybe 10.",
					WindowOpen = DateTime.Now,
					WindowClose = DateTime.Now.AddMinutes(90),
					Center = new Entities.Coordinates.GeoCoordinate
					{
						Latitude = 0,
						Longitude = 0,
						Altitude = 0
					},
					Name = "In Memory Test"
				};

				_ctx.ArrivalWindows.Add(arrivalWindow);
			}

			

			_ctx.SaveChanges();

			await Task.FromResult(0);
		}
	}
}
