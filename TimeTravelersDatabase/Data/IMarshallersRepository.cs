using System;
using System.Collections.Generic;

using TimeTravelersDatabase.Data.Entities;

namespace TimeTravelersDatabase.Data
{
	public interface IMarshallersRepository
	{
		#region Marshallers
		IEnumerable<Marshaller> GetAll();

		Marshaller GetMarshallerByKey(Guid key);
		#endregion  //	marshallers

		void AddEntity(object entity);

		void DeleteEntity(object entity);

		bool SaveAll();
	}
}
