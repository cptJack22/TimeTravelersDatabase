using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public class ArrivalWIndowsInMemoryRepository : IArrivalWindowsRepository
	{
		public void AddEntity(object model)
		{
			throw new NotImplementedException();
		}

		public void AddWindow(ArrivalWindow window)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ArrivalWindow> GetAllWindows(bool includeNewsAndWeather)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ArrivalWindow> GetAllWindowsByMarshaller(string usesrname, bool includeNewsAndWeather)
		{
			throw new NotImplementedException();
		}

		public ArrivalWindow GetWindowByKey(Guid key)
		{
			throw new NotImplementedException();
		}

		public bool SaveAll()
		{
			throw new NotImplementedException();
		}
	}
}
