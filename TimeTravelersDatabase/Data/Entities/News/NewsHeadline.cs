using System;

namespace TimeTravelersDatabase.Data.Entities.News
{
	public class NewsHeadline : ModelBase
	{
		#region Properties
		public string Headline { get; set; }

		public bool PinAsDayHeadline { get; set; }

		public bool PinAsWeekHeadline { get; set; }

		public bool PinAsMonthHeadline { get; set; }

		public bool PinAsYearHeadline { get; set; }

		public NewsHeadlineSource Source { get; set; }

		public string Url { get; set; }
		#endregion //	properties

		#region Constructors
		private void init()
		{
			Headline = String.Empty;
			Source = null;
			Url = String.Empty;
		}

		public NewsHeadline() : base()
		{
			init();
		}
		#endregion   //	constructors
	}
}
