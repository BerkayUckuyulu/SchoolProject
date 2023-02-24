using System;
namespace Entities.Base
{
	public class BaseClass
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public DateTime UpdatedDate { get; set; }
		public bool IsDeleted { get; set; }
	}
}

