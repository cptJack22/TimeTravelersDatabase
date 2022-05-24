using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public class ArrivalWindowsInMemoryRepository : IArrivalWindowsRepository
	{
		private readonly TimeTravelersDatabaseContext _ctx;
		private readonly ILogger<ArrivalWindowsInMemoryRepository> _logger;

		public ArrivalWindowsInMemoryRepository(
			TimeTravelersDatabaseContext ctx,
			ILogger<ArrivalWindowsInMemoryRepository> logger)
		{
			_ctx = ctx;
			_logger = logger;
		}

		#region Arrival Windows
		public IEnumerable<ArrivalWindow> GetAll(bool includeNewsAndWeather=false)
		{
			return _ctx.ArrivalWindows;
		}

		public IEnumerable<ArrivalWindow> GetAllWindowsByMarshaller(Guid key, bool includeNewsAndWeather=false)
		{
			var marshaller = _ctx.Marshallers.FirstOrDefault(m => m.Key == key);
			if (includeNewsAndWeather)
			{
				return _ctx.ArrivalWindows.Where(a => a.Marshallers.Contains(marshaller));
			}

			return _ctx.ArrivalWindows.Where(a => a.Marshallers.Contains(marshaller));
		}

		public ArrivalWindow GetWindowByKey(Guid key)
		{
			return _ctx.ArrivalWindows.FirstOrDefault(a => a.Key == key);
		}
		#endregion //	arrival windows

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
