using System;
namespace Entities.Base
{
	public class AppUser
	{
		public string? PhotoUrl { get; set; }
		public string? IdentityNumber { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime RefreshTokenEndDate { get; set; }
        public ICollection<Course> Courses { get; set; }
	}
}

