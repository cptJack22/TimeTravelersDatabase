using System;

namespace TimeTravelersDatabase.Data.Entities
{
	/// <summary>
	///	General pupose base class for entities
	/// </summary>
	public class EntityBase
	{
		#region Properties
		/// <summary>
		/// May of the records may be subject to approval before becoming public.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// Meta data - which user created this record and when.
		/// </summary>
		public DateTime CreatedWhen { get; set; }
		
		/// <summary>
		/// Meta data - which user created this record and when.
		/// </summary>
		public Guid CreatedWho { get; set; }

		/// <summary>
		/// Primary Identifier to the record.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Guid key for any record. In some cases, it might be useful not to have a predictable public-facing identity.
		/// Records not using the key, may simpley leave it Guid.Empty
		/// </summary>
		public Guid Key { get; set; }

		/// <summary>
		/// /// <summary>
		/// Meta data - which user updated this record and when.
		/// </summary>
		/// </summary>
		public DateTime UpdatedWhen { get; set; }

		/// <summary>
		/// /// <summary>
		/// Meta data - which user updated this record and when.
		/// </summary>
		/// </summary>
		public Guid UpdatedWho { get; set; }
		#endregion   //	properties

		#region Constructors
		private void init()
		{
			Active = false;
			CreatedWhen = new DateTime();
			CreatedWho = Guid.Empty;
			Id = -1;
			Key = Guid.Empty;
			UpdatedWhen = new DateTime();
			UpdatedWho = Guid.Empty;
		}

		public EntityBase() : base()
		{
			init();
		}
		#endregion //	constructors
	}
}
