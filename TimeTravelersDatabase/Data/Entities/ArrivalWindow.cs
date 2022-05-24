using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using TimeTravelersDatabase.Data.Entities.Coordinates;
using TimeTravelersDatabase.Data.Entities.News;

using UnitsNet;

namespace TimeTravelersDatabase.Data.Entities
{
	public class ArrivalWindow : EntityBase
	{
		#region Properties
		/// <summary>
		/// Location on the Earth at the center of the arrival window.
		/// At this time, we will only use circlular arrival windows.
		/// </summary>
		public GeoCoordinate Center { get; set; }

		/// <summary>
		/// Location of the Earth during the arrival window
		/// </summary>
		public GalacticCoordinate GalacticCoordinates { get; set; }

		/// <summary>
		/// Time Marshaller(s) responsible for the arrival window.
		/// </summary>
		public IEnumerable<Marshaller> Marshallers { get; set; }

		/// <summary>
		/// Human-friendly reference for the Arrival Window
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Collection of the top news headlines from the day, month, and year of the arrival window.
		/// </summary>
		public IEnumerable<NewsHeadline> NewsHeadlines { get; set; }

		/// <summary>
		/// Description of the arrival window population. This will provide travelers with audience information.
		/// </summary>
		[MaxLength(500)]
		public string PopulationDescription { get; set; }

		/// <summary>
		/// Radius from the ArrivalWindow.Center of the arrival window. Please make sure this is clear.
		/// </summary>
		/// <see cref="Center"/>
		public Length Radius { get; set; }

		/// <summary>
		/// Description of the arrival window physical area.
		/// </summary>
		/// <example>Park</example>
		/// <example>Stephen Hawking's Time Traveler Champaign Party</example>
		[MaxLength(500)]
		public string RegionDescrption { get; set; }

		/// <summary>
		/// Weather report for the arrival window.
		/// </summary>
		public WeatherReport Weather { get; set; }

		/// <summary>
		/// Date/Time of the window close. Arriving after the window close is not recommended, as it is no longer deemed safe.
		/// </summary>
		public DateTime WindowClose { get; set; }

		/// <summary>
		/// Date/Time of the window open. Arriving before the window open is not recommended, as it is not yet deemed safe. 
		/// However, arriving early would save the time marshaller's the effort of setting everything up for a safe arrival.
		/// </summary>
		public DateTime WindowOpen { get; set; }
		#endregion //	properties

		#region Constructors
		public ArrivalWindow() { init(); }

		private void init()
		{
			Center = new GeoCoordinate();
			Marshallers = null;
			Name = string.Empty;
			Radius = new Length(10, UnitsNet.Units.LengthUnit.Meter);
			Weather = new WeatherReport();
			WindowOpen = new DateTime();
			WindowClose = new DateTime();
		}
		#endregion //	constructors
	}
}
