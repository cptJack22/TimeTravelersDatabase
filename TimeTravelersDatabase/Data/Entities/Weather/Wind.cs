namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class Wind
	{
		#region Properties
		public WindDirection Direction { get; set; }

		/// <summary>
		/// Wind Speed.Contains Metric and Imperial Values.
		/// </summary>
		public object Speed { get; set; }

		/// <summary>
		/// Wind gust speed.Contains Metric and Imperial Values.
		/// </summary>
		public object WindGustSpeed { get; set; }
		#endregion //	properties
	}
}
