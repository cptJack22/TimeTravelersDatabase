﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTravelersDatabase.Data.Entities.Weather;
using TimeTravelersDatabase.Data.Entities.Weather.Units;

using static TimeTravelersDatabase.Data.Entities.Weather.Temperature;

namespace TimeTravelersDatabase.Data.Entities
{
	/// <summary>
	/// A weather report is useful for a successful arrival. It would be terribly 
	/// awkward for a grand arrival only to thave the travelers duck back inside 
	/// quickly to dress to the weather.
	/// </summary>
	public class CurrentWeather
	{
		#region Properties
		/// <summary>
		/// DateTime of the current observation, displayed in ISO8601 format.
		/// </summary>
		public DateTime LocalObservationDateTime { get; set; }

		public string FormattedLocalObservationDateTime => LocalObservationDateTime.ToUniversalTime().ToString("o");

		/// <summary>
		/// DateTime of the current observation, displayed as the number of 
		/// seconds that have elapsed since January 1, 1970 (midnight UTC/GMT).
		/// </summary>
		public Int64 EpochTime { get; set; }

		/// <summary>
		/// Phrase description of the current weather condition. Displayed in the 
		/// language set with language code in URL.
		/// </summary>
		public string WeatherText { get; set; }

		/// <summary>
		/// Numeric value representing an image that displays the current 
		/// condition described by WeatherText. May be NULL.
		/// </summary>
		public Int32 WeatherIcon { get;set; }

		public LocalSource LocalSource { get; set; }

		/// <summary>
		/// Flag indicating the time of day (true=day, false=night)
		/// </summary>
		public bool IsDayTime { get; set; }

		public Temperature Temperature { get; set; }

		/// <summary>
		/// Patented AccuWeather RealFeel Temperature.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits RealFeelTemperature { get; set; }

		/// <summary>
		/// Patented AccuWeather RealFeel Temperature in the shade. 
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits RealFeelTemperatureShade { get; set; }

		/// <summary>
		/// Relative humidity. May be NULL.
		/// </summary>
		public Int32 RelativeHumidity { get; set; }

		/// <summary>
		/// Dew point temperature.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits DewPoint { get; set; }

		public Wind Wind { get; set; }

		/// <summary>
		/// Measure of the strength of the ultraviolet radiation 
		/// from the sun. May be NULL.
		/// </summary>
		public Int32 UVIndex { get; set; }

		/// <summary>
		/// Text associated with the UVIndex.
		/// </summary>
		public string UVIndexText { get; set; }

		/// <summary>
		/// Visibility.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Visibility { get; set; }

		/// <summary>
		/// Cause of limited visibility.
		/// </summary>
		public string ObstructionsToVisibility { get; set; }

		/// <summary>
		/// Number representing the percentage of the sky that is 
		/// covered by clouds. May be NULL.
		/// </summary>
		public Int32 CloudCover { get; set; }

		/// <summary>
		/// Cloud ceiling.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Ceiling { get; set; }

		/// <summary>
		/// Atmospheric pressure.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Pressure { get; set; }

		public PressureTendency	PressureTendency { get; set; }

		/// <summary>
		/// Departure from the temperature observed 24 hours ago.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Past24HourTemperatureDeparture { get; set; }

		/// <summary>
		/// Perceived outdoor temperature caused by the combination 
		/// of air temperature, relative humidity, and wind speed.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits ApparentTemperature { get; set; }

		/// <summary>
		/// Perceived air temperature on exposed skin due to wind.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits WindChillTemperature { get; set; }

		/// <summary>
		/// The temperature to which air may be cooled by evaporating 
		/// water into it at constant pressure until it reaches 
		/// saturation.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits WetBulbTemperature { get; set; }

		/// <summary>
		/// Amount of precipitation(liquid water equivalent) 
		/// that has fallen in the past hour.
		/// Contains Metric and Imperial Values.
		/// </summary>
		public ImperialAndMetricUnits Precip1hr { get; set; }

		public PrecipitationSummary PrecipitationSummary { get; set; }
		
		public TemperatureSummary TemperatureSummary { get; set; }

		/// <summary>
		/// Link to current conditions for the requested location on AccuWeather`s mobile site.
		/// </summary>
		public string MobileLink { get; set; }

		/// <summary>
		/// Link to current conditions for the requested location on AccuWeather`s web site.
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Flag indicating the presence or absence of precipitation. True indicates 
		/// the presence of precipitation, false indicates the absence of precipitation.
		/// </summary>
		public bool HasPrecipitation { get; set; }

		/// <summary>
		/// If precipitation is present, the type of precipitation will be returned. 
		/// Possible values are Rain, Snow, Ice, or Mixed. 
		/// Null in the absence of precipitation.
		/// </summary>
		public string PrecipitationType { get; set; }

		/// <summary>
		/// The relative humidity in the user's home or building.
		/// </summary>
		public bool IndoorRelativeHumidity { get; set; }
		#endregion //	properties

		#region Constructors
		public CurrentWeather():base()
		{
			init();
		}

		private void init()
		{

		}
		#endregion	//	constructors
	}
}
