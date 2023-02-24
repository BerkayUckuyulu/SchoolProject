using System;
using Entities.Base;

namespace Entities
{
	public class Course:BaseClass
	{

		public ICollection<AppUser> AppUsers { get; set; }

	}
}

