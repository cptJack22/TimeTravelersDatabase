using System;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class LocalSource
	{
		#region Properties
		/// <summary>
		/// Numeric identifier unique to the local data provider.This parameter is not shown if there is not local source information to display.
		/// </summary>
		public Int32 Id { get; set; }

		/// <summary>
		/// Name of the local data provider, displayed in the language set with language code in URL, if available.Otherwise, Name is displayed in 
		/// English or the language in which the name was provided.This parameter is not shown if there is no local source information to display.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Weather code provided by the local data provider.This weather code allows the current condition to be matched to icons provided by the 
		/// local data provider instead of AccuWeather icons. This parameter is not shown if there is no local source information to display.
		/// </summary>
		public string WeatherCode { get; set; }
		#endregion  //	properties
	}
}
