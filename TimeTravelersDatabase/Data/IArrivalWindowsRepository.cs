using System;
using System.Collections.Generic;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public interface IArrivalWindowsRepository
	{
		#region Arrival Windows
		void AddWindow(ArrivalWindow window);

		IEnumerable<ArrivalWindow> GetAllWindows(bool includeNewsAndWeather);

		IEnumerable<ArrivalWindow> GetAllWindowsByMarshaller(string usesrname, bool includeNewsAndWeather);

		ArrivalWindow GetWindowByKey(Guid key);
		#endregion  //	arrivalWindows

		void AddEntity(object model);

		bool SaveAll();
	}
}
