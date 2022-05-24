using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public class MarshallersInMemoryRepository : IMarshallersRepository
	{
		private readonly TimeTravelersDatabaseContext _ctx;
		private readonly ILogger<MarshallersInMemoryRepository> _logger;

		public MarshallersInMemoryRepository(
			TimeTravelersDatabaseContext ctx,
			ILogger<MarshallersInMemoryRepository> logger)
		{
			_ctx = ctx;
			_logger = logger;
		}

		#region Marshallers
		public IEnumerable<Marshaller> GetAll()
		{
			return _ctx.Marshallers;
		}

		public Marshaller GetMarshallerByKey(Guid key)
		{
			return _ctx.Marshallers.FirstOrDefault(m => m.Key == key);
		}
		#endregion //	marshallers

		public void AddEntity(object entity)
		{
			_ctx.Add(entity);
		}

		public void DeleteEntity(object entity)
		{
			_ctx.Remove(entity);
		}

		public bool SaveAll()
		{
			return _ctx.SaveChanges() > 0;
		}
	}
}
