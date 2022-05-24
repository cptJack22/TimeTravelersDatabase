using System;

namespace TimeTravelersDatabase.Data.Entities.Weather.Units
{
	public class UnitBase
	{
		#region Properties
		/// <summary>
		/// Rounded value in specified units.
		/// May be NULL.
		/// </summary>
		public double Value { get; set; }

		/// <summary>
		/// Type of unit.
		/// </summary>
		public string Unit { get; set; }

		/// <summary>
		/// Numeric ID associated with the type 
		/// of unit being displayed.
		/// </summary>
		public Int32 UnitType { get; set; }
		#endregion  //	properties
	}
}
