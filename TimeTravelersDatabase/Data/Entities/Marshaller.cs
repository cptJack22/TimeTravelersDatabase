using System;
using System.Collections.Generic;

namespace TimeTravelersDatabase.Data.Entities
{
	/// <summary>
	/// Just like at an airport, a safe arrival requires a marshaller. 
	/// A Time Marshaller clears an arrival window and will likely be 
	/// the first contact a timetraveler makes. A Time Marshaller should 
	/// be prepared for this honor.
	/// </summary>
	public class Marshaller : ModelBase
	{
		#region Properties
		/// <summary>
		/// The marshaller's arrival windows.
		/// </summary>
		public IEnumerable<ArrivalWindow> ArrivalWindows { get; set; }

		/// <summary>
		/// Marshaller's first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Marshaller's last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Read-only combined first and last name.
		/// </summary>
		public string Name => string.Format("{0} {1}", FirstName, LastName);

		/// <summary>
		/// Read-only combined sort name (last, first).
		/// </summary>
		public string SortName => string.Format("{1}, {0}", FirstName, LastName);

		/// <summary>
		/// Each marshaller is connected to a user via the UserKey.
		/// </summary>
		public Guid UserKey { get; set; }
		#endregion //	properties

		#region Constructors
		public Marshaller() : base()
		{
			init();
		}

		private void init()
		{
			Active = true;
			FirstName = string.Empty;
			Id = -1;
			Key = Guid.Empty;
			LastName = string.Empty;
			UserKey = Guid.Empty;
		}
		#endregion //	constructors
	}
}
