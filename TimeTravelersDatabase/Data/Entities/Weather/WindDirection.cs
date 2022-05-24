using System;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class WindDirection
	{
		#region Properties
		/// <summary>
		/// Wind direction in Azimuth degrees(e.g. 180 degrees is a wind coming from the south). May be NULL.
		/// </summary>
		public Int32 Degrees { get; set; }

		/// <summary>
		/// Direction abbreviated in English.
		/// </summary>
		public string English { get; set; }

		/// <summary>
		/// Direction abbreviated in the language specified by language code in URL.
		/// </summary>
		public string Localized { get; set; }
		#endregion //	properties
	}
}
