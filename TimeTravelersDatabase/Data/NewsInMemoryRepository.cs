using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;

using TimeTravelersDatabase.Data.Entities.News;

namespace TimeTravelersDatabase.Data
{
	public class NewsInMemoryRepository : INewsRepository
	{
		private readonly TimeTravelersDatabaseContext _ctx;
		private readonly ILogger<NewsInMemoryRepository> _logger;

		public NewsInMemoryRepository(
			TimeTravelersDatabaseContext ctx,
			ILogger<NewsInMemoryRepository> logger)
		{
			_ctx = ctx;
			_logger = logger;
		}

		#region Headlines
		public IEnumerable<NewsHeadline> GetAllNewsHeadlines()
		{
			return _ctx.NewsHeadlines;
		}

		public NewsHeadline GetHeadlineById(int id)
		{
			return _ctx.NewsHeadlines.FirstOrDefault(x => x.Id == id);
		}
		#endregion //	headlines

		#region Sources
		public void DeleteSource(NewsHeadlineSource source, bool cascadeDeleteHeadlines)
		{
			if (cascadeDeleteHeadlines)
			{
				var headlines = _ctx.NewsHeadlines.Where(x => x.Id == source.Id);
				_ctx.NewsHeadlines.RemoveRange(headlines);
			}

			RemoveEntity(source);
		}

		public IEnumerable<NewsHeadlineSource> GetAllSourceNewsHeadlineSources()
		{
			return _ctx.NewsHeadlines.Select(x => x.Source);
		}
		#endregion	//	sources

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
