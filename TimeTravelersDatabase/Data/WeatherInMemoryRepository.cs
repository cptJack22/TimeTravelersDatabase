using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;

using TimeTravelersDatabase.Data.Entities;
using TimeTravelersDatabase.Data.Entities.Coordinates;

namespace TimeTravelersDatabase.Data
{
	public class WeatherInMemoryRepository : IWeatherRepository
	{
		private readonly TimeTravelersDatabaseContext _ctx;
		private readonly ILogger<WeatherInMemoryRepository> _logger;

		public WeatherInMemoryRepository(
			TimeTravelersDatabaseContext ctx,
			ILogger<WeatherInMemoryRepository> logger)
		{
			_ctx = ctx;
			_logger = logger;
		}

		#region Weather
		public IEnumerable<WeatherReport> GetCurrentWeather(GeoCoordinate where)
		{
			return _ctx.CurrentWeather;
		}

		public WeatherReport GetWeatherById(int id)
		{
			return _ctx.CurrentWeather.FirstOrDefault(x => x.Id == id);
		}
		#endregion //	weather

		public void AddEntity(object entity)
		{
			_ctx.Add(entity);
		}

		public void RemoveEntity(object entity)
		{
			_ctx.Remove(entity);
		}

		public bool SaveAll()
		{
			return _ctx.SaveChanges() > 0;
		}
	}
}
