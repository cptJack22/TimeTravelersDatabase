namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class TemperatureSummary : EntityBase
	{
		#region Properties
		/// <summary>
		/// The minimum/maximum temperature observed over the past 6 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public TemperatureSummaryRange Past6HourRange { get; set; }

		/// <summary>
		/// The minimum/maximum temperature observed over the past 12 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public TemperatureSummaryRange Past12HourRange { get; set; }

		/// <summary>
		/// The minimum/maximum temperature observed over the past 24 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public TemperatureSummaryRange Past24HourRange { get; set; }
		#endregion  //	properties
	}
}
