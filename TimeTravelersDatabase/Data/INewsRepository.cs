using System.Collections.Generic;

using TimeTravelersDatabase.Data.Entities.News;

namespace TimeTravelersDatabase.Data
{
	public interface INewsRepository
	{
		#region News Headlines
		IEnumerable<NewsHeadline> GetAllNewsHeadlines();

		NewsHeadline GetHeadlineById(int id);
		#endregion   //	news headlines

		#region Sources
		void DeleteSource(NewsHeadlineSource source, bool cascadeDeleteHeadlines);

		IEnumerable<NewsHeadlineSource> GetAllSourceNewsHeadlineSources();
		#endregion	//	sources

		void AddEntity(object entity);

		void RemoveEntity(object entity);

		bool SaveAll();
	}
}
