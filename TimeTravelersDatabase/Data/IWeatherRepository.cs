using System.Collections.Generic;

using TimeTravelersDatabase.Data.Entities;
using TimeTravelersDatabase.Data.Entities.Coordinates;

namespace TimeTravelersDatabase.Data
{
	public interface IWeatherRepository
	{
		#region Weather
		IEnumerable<WeatherReport> GetCurrentWeather(GeoCoordinate where);

		WeatherReport GetWeatherById(int id);
		#endregion  //	weather

		void AddEntity(object entity);

		void RemoveEntity(object entity);

		bool SaveAll();

	}
}
