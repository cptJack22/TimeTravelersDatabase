using System;

namespace TimeTravelersDatabase.Data.Entities
{
	public class UserTimestamp
	{
		#region Properties
		public DateTime When { get; set; }
		public Guid Who { get; set; }
		#endregion   //	properties

		#region Constructors
		public UserTimestamp(bool now = false) {
			init();

			if (now)
			{
				When = DateTime.Now;
			}

		}

		private void init()
		{
			When = DateTime.Now;
			Who = Guid.Empty;
		}
		#endregion //	constructors
	}
}
