using System;
using Entities.Base;

namespace Entities
{
	public class Outline:BaseClass
	{
		public string? Name { get; set; }
		public short Point { get; set; }
		public ICollection<Outline> Childs { get; set; }
	}
}

