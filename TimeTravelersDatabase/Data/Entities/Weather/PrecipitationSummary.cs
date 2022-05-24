using System.ComponentModel.DataAnnotations.Schema;

using UnitsNet;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class PrecipitationSummary : EntityBase
	{
		#region Properties
		/// <summary>
		/// Deprecated.
		/// Please use the precipitation summary for a specific time span.
		/// </summary>
		[NotMapped]
		public object Precipitation { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past hour.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume PastHour { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 3 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past3Hours { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 6 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past6Hours { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 9 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past9Hours { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 12 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past12Hours { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 18 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past18Hours { get; set; }

		/// <summary>
		/// The amount of precipitation (liquid equivalent) that 
		/// has fallen in the past 24 hours.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public Volume Past24Hours { get; set; }
		#endregion  //	properties
	}
}
