using System;
using System.Collections.Generic;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public interface IArrivalWindowsRepository
	{
		#region Arrival Windows
		IEnumerable<ArrivalWindow> GetAll(bool includeNewsAndWeather = false);

		IEnumerable<ArrivalWindow> GetAllWindowsByMarshaller(Guid key, bool includeNewsAndWeather = false);

		ArrivalWindow GetWindowByKey(Guid key);
		#endregion  //	arrivalWindows

		void AddEntity(object entity);

		void RemoveEntity(object entity);

		bool SaveAll();
	}
}
