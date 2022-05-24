
using UnitsNet;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class TemperatureSummaryRange : EntityBase
	{
		#region Properties
		/// <summary>
		/// The minimum temperature observed over a range.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Temperature Minimum { get; set; }

		/// <summary>
		/// The maximum temperature observed over  a range.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Temperature Maximum { get; set; }
		#endregion   //	properties
	}
}
