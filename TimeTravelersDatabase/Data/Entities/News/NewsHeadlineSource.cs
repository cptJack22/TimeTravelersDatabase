using System;

namespace TimeTravelersDatabase.Data.Entities.News
{
	public class NewsHeadlineSource : ModelBase
	{
		#region Properties
		public DateTime Date { get; set; }

		public string Description { get; set; }

		public string Name { get; set; }

		public string SourceUrlBase { get; set; }
		#endregion	properties

		#region Constructors
		private void init()
		{
			Date = DateTime.Now;
			Name = string.Empty;
			SourceUrlBase = string.Empty;
		}

		public NewsHeadlineSource() : base()
		{
			init();
		}
		#endregion   //	constructors
	}
}
