namespace TimeTravelersDatabase.Data.Entities.Coordinates
{
	/// <summary>
	/// Precise global location data for the purposes of pinpointing a location on Earth.
	/// </summary>
	public class GeoCoordinate : EntityBase
	{
		#region Properties
		/// <summary>
		/// Gets the altitude of the GeoCoordinate, in meters.
		/// </summary>
		public double Altitude { get; set; }

		/// <summary>
		/// Gets or sets the heading in degrees, relative to true north.
		/// </summary>
		public double Course { get; set; }

		/// <summary>
		/// Gets or sets the accuracy of the latitude and longitude that is given by the GeoCoordinate, in meters.
		/// </summary>
		public double HorizontalAccuracy { get; set; }

		/// <summary>
		/// Gets a value that indicates whether the GeoCoordinate does not contain latitude or longitude data.
		/// </summary>
		public bool IsUnkown { get; }

		/// <summary>
		/// Gets or sets the latitude of the GeoCoordinate.
		/// </summary>
		public double Latitude { get; set; }

		/// <summary>
		/// Gets or sets the longitude of the GeoCoordinate.
		/// </summary>
		public double Longitude { get; set; }

		/// <summary>
		/// Gets or sets the speed in meters per second.
		/// </summary>
		public double Speed { get; set; }

		/// <summary>
		/// Gets or sets the accuracy of the altitude given by the GeoCoordinate, in meters.
		/// </summary>
		public double VerticalAccuracy { get; set; }
		#endregion  //	properties
	}
}

