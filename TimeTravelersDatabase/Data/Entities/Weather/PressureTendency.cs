using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTravelersDatabase.Data.Entities.Weather
{
	public class PressureTendency
	{
		#region Properties
		/// <summary>
		/// Description of the pressure tendency in the language 
		/// specified by language code in the URL.
		/// </summary>
		public string LocalizedText { get; set; }

		/// <summary>
		/// Pressure tendency code regardless of language. 
		/// (F=falling, S=steady, R=rising)
		/// </summary>
		public string Code { get; set; }
		#endregion //	properties
	}
}
