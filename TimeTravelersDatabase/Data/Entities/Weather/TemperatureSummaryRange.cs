
using TimeTravelersDatabase.Data.Entities.Weather.Units;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class TemperatureSummaryRange
	{
		#region Properties
		/// <summary>
		/// The minimum temperature observed over a range.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Minimum { get; set; }

		/// <summary>
		/// The maximum temperature observed over  a range.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Maximum { get; set; }
		#endregion	//	properties
	}
}
